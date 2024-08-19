// Main loop body
#if defined(ARDUINO_SEEED_XIAO_M0)
const char* boardname = "Seeed";
#elif defined(ARDUINO_SAMD_ZERO)
const char* boardname = "Feather";
#else
const char* boardname = "UNKNOWN BOARD";
#endif

void setup() {
  setBootProt(2);
  uint32_t bootprot = getBootProt();

  // start serial port at 9600 bps:
  Serial.begin(115200);
  while (!Serial) {
    ;  // wait for serial port to connect. Needed for native USB port only
  }
  Serial.println(boardname);
  pinMode(PullDownPin, INPUT_PULLDOWN);
  pinMode(ButtonPin, INPUT_PULLUP);
  pinMode(LEDPin, OUTPUT);
  ChangeInterrupt(false);
  if (boardname == "Feather")
  {
    attachInterrupt(PullUpPin, PullUpInterrupt, LOW);
    Serial.println("Attached Interrupt");
  }

  //ADC_Init();
  analogReadResolution(14);

  establishContact();  // send a byte to establish contact until receiver responds

}

void loop() {
  int buttonState = 0;

  getSerialChars();

  if (input[0] == 'T')  // Button trigger test mode
  {
    while (input[0] != 'X') {
      Serial.setTimeout(100);
      getSerialChars();
      if (inputType == 0) {
        if (digitalRead(ButtonPin)) {
          if (sensorType == 1) {
            if (autoClick) {
              for (int i = 0; i < shotCount; i++) {
                runAudioTest();
                //delay(timeBetween * 1000);
                delay(100);
              }
              Serial.println("AUDIO TEST FINISHED");
              break;
            } else {
              runAudioTest();
            }
          } else {
            autoRunTest(autoClick, 12000, shotCount);
            if (autoClick) {
              break;
            }
          }
        }
      } else if (sourceType == 1 || sourceType == 5 || sourceType == 6) {
        if (inputType == 1)
        {
          runClickTest(); 
        }
        else if (inputType == 2)
        {
          runClickTest2Pin();
        }
        else if (inputType == 3)
        {
          runClickTest3Pin();
        }
        break;
      } else if (inputType == 1 && sensorType == 0) // mic trigger, light sensor data source. Console testing mode
      {
        micBaseline = setMicBaseline();
        while (input[0] != 'X') {
          if (digitalRead(ButtonPin)) {
            input[0] = 'X';
            toggleLED(false);
            Serial.println("FINISHED");
          }
          if (analogRead(1) > micBaseline)
          {
            autoRunTest(false, 12000);
            toggleLED(true);
            getSerialChars();
            delay(300);
            toggleLED(false);
          }
        }
      } else if (inputType == 2) {
        while (input[0] != 'X') {
          getSerialChars();
          if (digitalRead(PullDownPin) != HIGH) {
            // Run test
            autoRunTest(false, 12000);
          }
        }
        break;
      } 
    }
  } else if (input[0] == 'P')  // Pre-test
    {
      Serial.println("pretest starting");
      int localInputType = inputType;
      int localSourceType = sourceType;
      inputType = 0;
      sourceType = 0;
      while (input[0] != 'X') {
        getSerialChars();
        if (digitalRead(ButtonPin)) {
          autoRunTest(true, 9000, 50, true); // set this back to 50 or 100
          inputType = localInputType;
          sourceType = localSourceType;
          input[0] = 'X';

        }
      }
  } else if (input[0] == 'I')  // Initialise everything
  {
    toggleLED(true);

    Serial.print("FW:");
    Serial.println(firmwareVersion);

    // Sensor type - bit 1
    sensorType = convertHexToDec(input[1]) - 1;

    // Trigger type - bit 2
    inputType = convertHexToDec(input[2]) - 1;
    if (inputType == 3)
    {
      ChangeInterrupt(true);
      inputType--;
    }
    else if (inputType == 2)
    {
      ChangeInterrupt(false);
    }
    if (inputType == 4) { inputType--;}

    // Auto Click - bit 3
    if (input[3] == '1') {
      autoClick = true;
    } else {
      autoClick = false;
    }

    // DirectX - bit 4
    sourceType = convertHexToDec(input[4]) - 1;
    if (sourceType == 3) { setAGain(true); }
    else { setAGain(false); }

    // Shot count - bit 5 + 6
    int msb = convertHexToDec(input[5]);
    int lsb = convertHexToDec(input[6]);
    shotCount = (msb * 100) + (lsb * 10);

    // Time between - bit 7
    int tbw = convertHexToDec(input[7]);
    if (tbw == 1) {
      timeBetween = 0.5;
    } else {
      timeBetween = tbw - 1;
    }

    // Mouse Action - bit 8
    MouseAction = convertHexToDec(input[8]);

    // Confirm settings synced
    for (int i = 0; i < INPUT_SIZE; i++) {
      Serial.print(input[i]);
    }
    Serial.println();
    Serial.println("Settings Synced");

  } else if (input[0] == 'S')  // Shot count
  {
    Serial.println("Ready");
    getSerialChars();
    int MSB = convertHexToDec(input[1]);
    int LSB = convertHexToDec(input[0]);
    shotCount = (MSB * 100) + (LSB * 10);
  } else if (input[0] == 'Q') {
    while (input[0] != 'X') {
      getSerialChars();
      int pulldown = digitalRead(PullDownPin);
      Serial.println(pulldown);
      if (pulldown == LOW) {
        pulseLED(true);
      } else {
        pulseLED(false);
      }
      delay(100);
    }
  } else if (input[0] == 'W') {
    if (input[1] == '1')
    {
      while (!digitalRead(ButtonPin)) {
        delay(1);
      }
      long fourteen = fillADCBufferSlower(ArraySize, 1);

      for (int i = 0; i < ArraySize; i++) {
        Serial.print(adcBuff[i]);
        Serial.print(",");
      }
      Serial.println();
    }
    else if (input[1]=='2')
    {
      while (!digitalRead(ButtonPin)) {
        delay(1);
      }
      long fourteen = fillADCBuffer(ArraySize, 0);

      for (int i = 0; i < ArraySize; i++) {
        Serial.print(adcBuff[i]);
        Serial.print(",");
      }
      Serial.println();
      }
      else if (input[1]=='3')
    {
      long fourteen = fillADCBufferSlower(ArraySize, 1);
      Serial.print("MICTEST:");
      for (int i = 0; i < ArraySize; i++) {
        Serial.print(adcBuff[i]);
        Serial.print(",");
      }
      Serial.println();
      }
  } else if (input[0] == 'Y') {
    Serial.setTimeout(100);
    int counter = 100;
    getSerialChars();
    while (input[0] != 'X'){
      getSerialChars();
      if (digitalRead(ButtonPin)) {
        for (int i = 0; i < counter; i++){
          long click = micros();
          Mouse.click(MOUSE_LEFT);
          //Keyboard.write('A');
          //Serial.println("CLICKTEST");
          long start = micros();
          while (input[0] != 'H' && input[0] != 'X') {
            getClickChar();
            //getSerialChars();
          }
          long end = micros();
          long time = end - start;
          adcBuff[i] = time;
          
          Serial.println(i);
          getSerialChars();
          delay(500 + random(300));
        }
        input[0]='X';
      }
    }
    long avg = 0;
    for (int i = 0; i < counter; i++) {
      avg += adcBuff[i];
      Serial.print(adcBuff[i]);
      Serial.print(",");
    }
    Serial.println();
    avg /= counter;
    Serial.print("average time: ");
    Serial.println(avg);
    Serial.print("number of tests ran: ");
    Serial.println(counter);
  } else if (input[0] == 'Z') {
    while (digitalRead(ButtonPin) == LOW)
    {
      if (InterruptFlag)
      {
        Serial.println("Interrupted");
        InterruptFlag = false;
      }
      
    }
  }
}
