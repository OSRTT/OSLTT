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
      Serial.setTimeout(100);
      getSerialChars();
      if (inputType == 0)
      {
        if (digitalRead(ButtonPin))
        {
          if (sensorType == 1)
          {
            if (autoClick)
            {
              for (int i = 0; i < shotCount; i++)
              {
                runAudioTest();
                //delay(timeBetween * 1000);
                delay(100);
              }
              Serial.println("AUDIO TEST FINISHED");
              break;
            }
            else
            {
              runAudioTest();
            }
          }
          else
          {
            autoRunTest(autoClick, 9000, shotCount);
            if (autoClick)
            {
              break;
            }
          }
        }
      }
      else if (inputType == 1)
      {
        runClickTest();
        break;
      }
      else if (inputType == 2)
      {
        while(input[0] != 'X')
        {
          getSerialChars();
          if (digitalRead(PullDownPin) != HIGH)
          {
            // Run test
            autoRunTest(false, 9000);
          }
        }
        break;
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
        autoRunTest(true, 9000, 100, true);
      }
    }
  }
  else if (input[0] == 'I') // Initialise everything
  {
    toggleLED(true);
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
      if (input[3] == '1')
      {
        autoClick = true;
      }
      else
      {
        autoClick = false;
      }

      // DirectX - bit 4
      sourceType = convertHexToDec(input[4]) - 1;
         
      // Shot count - bit 5 + 6
      int msb = convertHexToDec(input[5]);
      int lsb = convertHexToDec(input[6]);
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
   
    while(!digitalRead(ButtonPin))
    {
      delay(1);
    }
    long fourteen = fillADCBufferSlower(14000, 1);
    
    for (int i = 0; i < 14000; i++) {
      Serial.print(adcBuff[i]);
      Serial.print(",");
    }
    Serial.println();
    Serial.println("0");
  }
  else if (input[0] == 'Y')
  {
    toggleLED(true);
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
