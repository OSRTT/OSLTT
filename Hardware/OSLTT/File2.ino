// Setup and helper functions


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


int getADCValue(int count, int pin = 0)
{
  uint32_t value = 0;
  int localCounter = 0;
  while (localCounter < count)
  {
    
    value += analogRead(pin);
    localCounter++;
  }
  value /= count;
  return value;
}

long fillADCBuffer(int count, int pin = 0)
{

  int localCounter = 0;
  long startTimer = micros();
  while (localCounter < count)
  {
    adcBuff[localCounter] = analogRead(pin);
    localCounter++;
  }
  long endTimer = micros();
  return endTimer - startTimer;
}

int getSingleADCValue(int pin = 0) {
  return analogRead(pin);
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
    analogWrite(3,0);
  }
}

void toggleLED(bool state)
{
  if (state) 
  {
    analogWrite(3, 0xFF);
  }
  else
  {
    analogWrite(3, 0x00);
  }
}

void runTest(int sampleCount = 9000, String textType = "RES:")
{
  int pin = 0;
  if (sensorType == 1)
  {
    pin = 1;
  }
  unsigned long clickTime = micros();
  Serial.print("input type: ");
  Serial.print(inputType);
  Serial.print(" & directXMode: ");
  Serial.println(directXMode);
  if (inputType == 0 && directXMode)
  {
    Mouse.click(MOUSE_LEFT);
  }
  unsigned long start_time = micros();  
  long timeTaken = fillADCBuffer(sampleCount, pin);
  toggleLED(true);
  long localStartValue = 0;
  int triggerSampleNum = 0;
  Serial.print(textType);
  Serial.print(start_time - clickTime);
  Serial.print(",");
  Serial.print(timeTaken);
  Serial.print(","); 
  Serial.print(sampleCount);
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
  Serial.println(result / 1000);
  toggleLED(false);
}

void autoRunTest(bool autoRun = true, int sampleCount = 9000, int clickCount = 100, bool pretest = false)
{
  if (autoRun)
  {
    int localCounter = 0;
    Serial.setTimeout(100);
    while (input[0] != 'X' && localCounter < clickCount )
    {

      runTest(sampleCount);
      long timer1 = millis();
      getSerialChars();
      long targetTime = timer1 + (timeBetween * 1000);
      while (millis() > targetTime) { delay(1); }
      localCounter++;
    }
    Serial.println("AUTO FINISHED");
  }
  else if (!autoRun)
  {
    runTest(sampleCount);
    Serial.println("SINGLE FIRE");
  }
  else if (pretest)
  {
    int localCounter = 0;
    while (input[0] != 'X' && localCounter < clickCount )
    {
      getSerialChars();
      runTest(sampleCount, "PRETEST:");
      localCounter++;
    }
    Serial.println("PRETEST FINISHED");
  }
}
