// Setup and helper functions


// ADC Setup

// AVG CTRL Sample count 4 (14 bit), 87.5ksps
// MuxPos 0x00 pin A0
// MuxPos 0x01 pin A1


//AVGCTRL.bit.SAMPLENUM = 0x2;
// CTRALB.bitPRESCALER - NOT SURE. 0x0 is DIV4 (stock),
//CTRLB.bit.RESSEL = 0x1 (16 bit)
// CTRLB.bit.CORREN - enable gain and offset 
//CTRLB.bit.diffmode = 0;
//CTRLB.bit.FREERUN = 1;

// INPUTCTRL.bit.GAIN - 0x0 for 1x, to 0x4 for 16x

// STATUS.bit.SYNCBUSY

void ADC_Init()
{
  /* Enable the APB clock for the ADC. */
  PM->APBCMASK.reg |= PM_APBCMASK_ADC;

  /* Enable GCLK1 for the ADC */
  GCLK->CLKCTRL.reg = GCLK_CLKCTRL_CLKEN | GCLK_CLKCTRL_GEN_GCLK1 | GCLK_CLKCTRL_ID_ADC;

  /* Wait for bus synchronization. */
  while (GCLK->STATUS.bit.SYNCBUSY) {};

  uint32_t bias = (*((uint32_t *) ADC_FUSES_BIASCAL_ADDR) & ADC_FUSES_BIASCAL_Msk) >> ADC_FUSES_BIASCAL_Pos;
  uint32_t linearity = (*((uint32_t *) ADC_FUSES_LINEARITY_0_ADDR) & ADC_FUSES_LINEARITY_0_Msk) >> ADC_FUSES_LINEARITY_0_Pos;
  linearity |= ((*((uint32_t *) ADC_FUSES_LINEARITY_1_ADDR) & ADC_FUSES_LINEARITY_1_Msk) >> ADC_FUSES_LINEARITY_1_Pos) << 5;

  /* Wait for bus synchronization. */
  while (ADC->STATUS.bit.SYNCBUSY) {};

  /* Write the calibration data. */
  ADC->CALIB.reg = ADC_CALIB_BIAS_CAL(bias) | ADC_CALIB_LINEARITY_CAL(linearity);
  while (ADC->STATUS.bit.SYNCBUSY) {};

  ADC->INPUTCTRL.bit.GAIN = 0;
  while (ADC->STATUS.bit.SYNCBUSY) {};

  ADC->INPUTCTRL.reg = ADC_INPUTCTRL_GAIN_1X | ADC_INPUTCTRL_MUXNEG_GND | ADC_INPUTCTRL_MUXPOS_PIN0;

  //Choose 16-bit resolution to oversample - use 12BIT_VAL for 1MSPS
  ADC->CTRLB.reg = ADC_CTRLB_PRESCALER_DIV4 | ADC_CTRLB_RESSEL_16BIT; // or just 0x1...
  while (ADC->STATUS.bit.SYNCBUSY) {};
  
  ADC->CTRLB.bit.FREERUN = 1;
  while (ADC->STATUS.bit.SYNCBUSY) {};

  //Sampletime set to 0
  ADC->SAMPCTRL.reg = 0;
  while (ADC->STATUS.bit.SYNCBUSY) {};

  // Accumulate samples to gain higher final result precision
  ADC->AVGCTRL.reg = ADC_AVGCTRL_SAMPLENUM_4 | ADC_AVGCTRL_ADJRES(0);
  while (ADC->STATUS.bit.SYNCBUSY) {};

  ADC->CTRLB.bit.DIFFMODE = 0;
  while (ADC->STATUS.bit.SYNCBUSY) {};

  ADC->CTRLB.bit.CORREN = 0; // 1 for gain
  while (ADC->STATUS.bit.SYNCBUSY) {};

  ADC->INPUTCTRL.bit.GAIN = 0; // up to 0x4 for 16x gain
  while (ADC->STATUS.bit.SYNCBUSY) {};

    //Select VDDANA (3.3V chip supply voltage as reference)
  ADC->REFCTRL.reg = ADC_REFCTRL_REFSEL_INTVCC1;
  while (ADC->STATUS.bit.SYNCBUSY) {};

  //Enable ADC
  ADC->SWTRIG.bit.START = 1;
  ADC->CTRLA.bit.ENABLE = 1;

  //wait for ADC to be ready
  while (ADC->STATUS.bit.SYNCBUSY) {};
}

void Swap_ADC_Input(int input)
{
    ADC->INPUTCTRL.bit.MUXPOS = input; // PIN A0, SWITCH TO = 1 for AUDIO
  while ( ADC->STATUS.bit.SYNCBUSY  );
}

void getSerialChars()
{
  for (int i = 0; i < INPUT_SIZE + 1; i++)
  {
    input[i] = ' ';
  }
  byte size = Serial.readBytes(input, INPUT_SIZE);
  input[size] = 0;
}

void establishContact() {
  while (Serial.available() <= 0) {
    Serial.println('OSLTT');   // send a capital A
    delay(250);
  }
}


int getADCValue(int count)
{
  uint32_t value = 0;
  int localCounter = 0;
  while (localCounter < count)
  {
    ADC->SWTRIG.bit.START = 1; //Start ADC
    while (!ADC->INTFLAG.bit.RESRDY) {}; //wait for ADC to have a new value
    value += ADC->RESULT.reg;
    localCounter++;
  }
  value /= count;
  return value;
}

long fillADCBuffer(int count)
{

  int localCounter = 0;
  long startTimer = micros();
  while (localCounter < count)
  {
    ADC->SWTRIG.bit.START = 1; //Start ADC
    while (!ADC->INTFLAG.bit.RESRDY) {}; //wait for ADC to have a new value
    adcBuff[localCounter] = ADC->RESULT.reg;
    localCounter++;
  }
  long endTimer = micros();
  return endTimer - startTimer;
}

int getSingleADCValue() {
  ADC->SWTRIG.bit.START = 1; //Start ADC
  while (!ADC->INTFLAG.bit.RESRDY) {}; //wait for ADC to have a new value
  return ADC->RESULT.reg;
}

int convertHexToDec(char c)
{
  if (c <= 57)
  {
    return c - '0'; // Convert char to int
  }
  else
  {
    return c - 55;
  }
}


void pulseLED(bool state)
{
  if (state)
  {
    for (int i = 0; i < 255; i++)
    {
      analogWrite(3, i);
      delay(5);
    }
  }
  else
  {
    for (int i = 255; i > 0; i--)
    {
      analogWrite(3, i);
      delay(5);
    }
  }
}

void toggleLED()
{
  if (LEDState) // if high, set low
  {
    analogWrite(3, 0x00);
  }
  else
  {
    analogWrite(3, 0xFF);
  }
}

void runTest(int sampleCount = 9000)
{
  if (sensorType == 0)
  {
    Swap_ADC_Input(0);
  }
  else
  {
    Swap_ADC_Input(1);
  }
  long timeTaken = fillADCBuffer(sampleCount);
  pulseLED(true);
  long localStartValue = 0;
  int triggerSampleNum = 0;
  Serial.print("RES:");
  Serial.print(sampleCount);
  Serial.print(",");
  Serial.print(timeTaken);
  Serial.print(",");        
  for (int i = 0; i < sampleCount; i++)
  {
    Serial.print(adcBuff[i]);
    Serial.print(",");
    if (i < 100)
    {
      localStartValue += adcBuff[i];
    }
    else if (i == 100)
    {
      localStartValue /= 100;
    }
    else
    {
      if (adcBuff[i] > (localStartValue * 2) && triggerSampleNum == 0)
      {
        triggerSampleNum = i;
      }
    }
  }
  Serial.println();
  Serial.print("RESULT:");
  double result = (timeTaken / sampleCount) * triggerSampleNum; 
  Serial.print(result / 1000);
  pulseLED(false);
}

void autoRunTest(bool autoRun = true, int sampleCount = 9000, int clickCount = 100)
{
  if (autoRun)
  {
    int localCounter = 0;
    while (input[0] != 'X' && localCounter < clickCount )
    {
      getSerialChars();
      runTest(sampleCount);
      localCounter++;
    }
  }
  else
  {
    runTest(sampleCount);
  }
}

