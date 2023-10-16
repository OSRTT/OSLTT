// Main loop body


void setup() {
  uint32_t bootprot = getBootProt();
  setBootProt(2);
  uint32_t newbootprot = getBootProt();


  // start serial port at 9600 bps:
  Serial.begin(115200);
  while (!Serial) {
    ;  // wait for serial port to connect. Needed for native USB port only
  }

  pinMode(PullDownPin, INPUT_PULLDOWN);
  pinMode(ButtonPin, INPUT_PULLUP);
  pinMode(LEDPin, OUTPUT);

  //ADC_Init();
  analogReadResolution(14);

  establishContact();  // send a byte to establish contact until receiver responds

  
  Serial.print("bootprot = ");
  Serial.println(bootprot);

  Serial.print("new bootprot = ");
  Serial.println(newbootprot);
}

void loop() {
  int buttonState = 0;

  getSerialChars();

  if (input[0] == 'T')  // Button trigger test mode
  {
    if (input[1] == 'P')  // Pre-test
    {
      while (input[0] != 'X') {
        getSerialChars();
        if (digitalRead(ButtonPin)) {
          autoRunTest(true, 9000, 50, true);
        }
      }
    }
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
            autoRunTest(autoClick, 9000, shotCount);
            if (autoClick) {
              break;
            }
          }
        }
      } else if (sourceType == 1 || sourceType == 5) {
        if (inputType == 1)
        {
          runClickTest(); 
        }
        else if (inputType == 2)
        {
          runClickTest2Pin();
        }
        break;
      } else if (inputType == 2) {
        while (input[0] != 'X') {
          getSerialChars();
          if (digitalRead(PullDownPin) != HIGH) {
            // Run test
            autoRunTest(false, 9000);
          }
        }
        break;
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

    // Auto Click - bit 3
    if (input[3] == '1') {
      autoClick = true;
    } else {
      autoClick = false;
    }

    // DirectX - bit 4
    sourceType = convertHexToDec(input[4]) - 1;

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

    while (!digitalRead(ButtonPin)) {
      delay(1);
    }
    long fourteen = fillADCBufferSlower(ArraySize, 1);

    for (int i = 0; i < ArraySize; i++) {
      Serial.print(adcBuff[i]);
      Serial.print(",");
    }
    Serial.println();
    Serial.println("0");
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
    while (input[0] != 'X')
    {
      getSerialChars();
      if (digitalRead(ButtonPin))
      {
        Mouse.move(127, 0);
        delay(1000);
        Mouse.move(-127, 0);
      }
      
    }
  }
}
