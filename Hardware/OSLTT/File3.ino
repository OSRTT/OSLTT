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

  ADC_Init();
  establishContact();  // send a byte to establish contact until receiver responds
}

void loop() {
  int buttonState = 0;
  
  getSerialChars();

  if (input[0] == 'A') // Button trigger test mode
  {
    while(input[0] != 'X')
    {
      getSerialChars();
      if (digitalRead(ButtonPin))
      {
        // Run test
        runTest(9000);
      }
    }
  }
  else if (input[0] == 'B') // Audio trigger test mode
  {
    Swap_ADC_Input(1);
    int baseline = getADCValue(500);
    while (input[0] != 'X')
    {
      if (digitalRead(ButtonPin))
      {
        input[0] = 'X';
      }
      int current = getSingleADCValue();
      Serial.print("audio:");
      Serial.println(current);
      if (current > (baseline * 2))
      {
        // Audio trigger
        // run test
        Swap_ADC_Input(0);
        runTest(9000);
      }
    }
  }
  else if (input[0] == 'C') // Pin input trigger test mode
  {
    while(input[0] != 'X')
    {
      getSerialChars();
      if (digitalRead(PullDownPin))
      {
        // Run test
        runTest(9000);
      }
    }
  }
  else if (input[0] == 'D') // Button trigger, audio latency
  {
    while(input[0] != 'X')
    {
      getSerialChars();
      if (digitalRead(ButtonPin))
      {
        // listen to audio port for spike
      }
    }
  }
  else if (input[0] == 'I') // Initialise everything
  {
    Serial.print("FW:");
    Serial.println(firmwareVersion);
  }
  else if (input[0] == 'S') // Shot count
  {
    Serial.println("Ready");
    getSerialChars();
    int MSB = convertHexToDec(input[0]);
    int LSB = convertHexToDec(input[1]);
    shotCount = (MSB * 100) + (LSB * 10);
  }
  else if (input[0] == 'Y')
  {
    while (input[0] != 'X')
    {
      int pulldown = digitalRead(PullDownPin);
      Serial.println(pulldown);
      if (pulldown == HIGH)
      {
        pulseLED(true);
      }
      delay(100);
    }
  }
  else if (input[0] == 'Z')
  {
    Serial.println("Z registered");
    Swap_ADC_Input(0);
    Serial.println("Swapped input");
    int buttonState = digitalRead(ButtonPin);
    Serial.print("Read button - ");
    Serial.println(buttonState);
    // ADC->SWTRIG.bit.START = 1; //Start ADC
    // while (!ADC->INTFLAG.bit.RESRDY); //wait for ADC to have a new value
    // int result = ADC->RESULT.reg;
    // Serial.println(result);
    while (buttonState != HIGH)
    {
      int value = getSingleADCValue();
      //int value = analogRead(A1);
      Serial.println(value);
      buttonState = digitalRead(ButtonPin);
    }
    Serial.println("Exited");
  }


}