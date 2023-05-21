// Main loop body


void setup() {
  // start serial port at 9600 bps:
  Serial.begin(115200);
  while (!Serial) {
    ; // wait for serial port to connect. Needed for native USB port only
  }

  pinMode(PullDownPin, INPUT_PULLDOWN);   
  pinMode(ButtonPin, INPUT_PULLUP);
  pinMode(LEDPin, OUTPUT);

  //ADC_Init();
  analogReadResolution(14);

  establishContact();  // send a byte to establish contact until receiver responds
}

void loop() {
  int buttonState = 0;
  
  getSerialChars();

  if (input[0] == 'T') // Button trigger test mode
  {
    while(input[0] != 'X')
    {
      getSerialChars();
      if (inputType == 0)
      {
        if (digitalRead(ButtonPin))
        {
          if (sensorType == 1)
          {
            long start = micros();
            Serial.println("AUDIO TRIGGER");
            long end = micros();
            autoRunTest(9000);
            Serial.print("AUDIO SERIAL DELAY:");
            Serial.println(end - start);
          }
          else
          {
            autoRunTest(9000);
          }
        }
      }
      else if (inputType == 1)
      {
        int baseline = getADCValue(500, 1);
        while (input[0] != 'X')
        {
          //getSerialChars();
          if (digitalRead(ButtonPin))
          {
            input[0] = 'X';
          }
          int current = getSingleADCValue(1);
          Serial.print("AUDIO:");
          Serial.println(current);
          int baselineAdjusted = 16380 - baseline;
          baselineAdjusted *= 0.5;
          if (current > (baseline + baselineAdjusted))
          {
            // Audio trigger
            // run test
            autoRunTest(9000);
          }
        }
      }
      else if (inputType == 2)
      {
        while(input[0] != 'X')
        {
          getSerialChars();
          if (digitalRead(PullDownPin) != HIGH)
          {
            // Run test
            autoRunTest(9000);
          }
        }
      }
    }
  }
  else if (input[0] == 'P') // Pre-test
  {
    while(input[0] != 'X')
    {
      getSerialChars();
      if (digitalRead(ButtonPin))
      {
        autoRunTest(9000, 100, true);
      }
    }
  }
  else if (input[0] == 'I') // Initialise everything
  {
    if (input[1] == ' ' || input[2] == ' ')
    {
      Serial.print("FW:");
      Serial.println(firmwareVersion);
    }
    else
    {
      // Sensor type - bit 1

      sensorType = convertHexToDec(input[1]) - 1;

      // Trigger type - bit 2
      inputType = convertHexToDec(input[2]) - 1;

      // Auto Click - bit 3
      if (input[3] == 1)
      {
        autoClick = true;
      }
      else
      {
        autoClick = false;
      }

      // DirectX - bit 4
      if (input[4] == 1)
      {
        directXMode = true;
      }
      else
      {
        directXMode = false;
      }
      
      // Shot count - bit 5 + 6
      int msb = convertHexToDec(input[6]);
      int lsb = convertHexToDec(input[5]);
      shotCount = (msb * 100) + (lsb * 10);

      // Time between - bit 7
      int tbw = convertHexToDec(input[0]);
      if (tbw == 1)
      {
        timeBetween = 0.5;
      }
      else
      {
        timeBetween = tbw - 1;
      }

      // Confirm settings synced
      for (int i = 0; i < INPUT_SIZE; i++)
      {
        Serial.print(input[i]);
      }
      Serial.println();
      Serial.println("Settings Synced");
    }
  }
  else if (input[0] == 'S') // Shot count
  {
    Serial.println("Ready");
    getSerialChars();
    int MSB = convertHexToDec(input[1]);
    int LSB = convertHexToDec(input[0]);
    shotCount = (MSB * 100) + (LSB * 10);
  }
  else if (input[0] == 'Q')
  {
    while (input[0] != 'X')
    {
      getSerialChars();
      int pulldown = digitalRead(PullDownPin);
      Serial.println(pulldown);
      if (pulldown == LOW)
      {
        pulseLED(true);
      }
      else
      {
        pulseLED(false);
      }
      delay(100);
    }
  }
  else if (input[0] == 'W')
  {
    // delay(1000);
    // for (int i = 0; i < 50000; i++)
    // {
    //   Serial.print(getSingleADCValue(1));
    //   Serial.print(",");
    // }
    // Serial.println();
    int baseline = getADCValue(500, 1);
    //Serial.setTimeout(100);
    while (input[0] != 'X')
    {
      //getSerialChars();
      if (digitalRead(ButtonPin))
      {
        input[0] = 'X';
      }
      int current = getSingleADCValue(1);
      Serial.print("AUDIO:");
      Serial.println(current);
      int baselineAdjusted = 16380 - baseline;
      baselineAdjusted *= 0.5;
      if (current < (baseline - 100))
      {
        // Audio trigger
        // run test
        Serial.println("Audio trigger detected");
      }
    }
  
  }
  else if (input[0] == 'Y')
  {
    Serial.println("Y registered");
    Serial.println("Audio sensor");
    int buttonState = digitalRead(ButtonPin);
    Serial.print("Read button - ");
    Serial.println(buttonState);
    // ADC->SWTRIG.bit.START = 1; //Start ADC
    // while (!ADC->INTFLAG.bit.RESRDY); //wait for ADC to have a new value
    // int result = ADC->RESULT.reg;
    // Serial.println(result);
    while (buttonState != HIGH)
    {
      //int value = getSingleADCValue();
      int value = analogRead(1);
      Serial.println(value);
      buttonState = digitalRead(ButtonPin);
    }
    Serial.println("Exited");
  }
  else if (input[0] == 'Z')
  {
    Serial.println("Z registered");
    Serial.println("Light sensor");
    int buttonState = digitalRead(ButtonPin);
    Serial.print("Read button - ");
    Serial.println(buttonState);
    // ADC->SWTRIG.bit.START = 1; //Start ADC
    // while (!ADC->INTFLAG.bit.RESRDY); //wait for ADC to have a new value
    // int result = ADC->RESULT.reg;
    // Serial.println(result);
    while (buttonState != HIGH)
    {
      //int value = getSingleADCValue();
      int value = analogRead(0);
      Serial.println(value);
      buttonState = digitalRead(ButtonPin);
    }
    Serial.println("Exited");
  }


}
