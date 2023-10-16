// Setup and helper functions

static inline void wait_ready(void) {
    while (NVMCTRL->INTFLAG.bit.READY == 0) {
    }
}

void exec_cmd(uint32_t cmd, const uint32_t *addr) {
    NVMCTRL->STATUS.reg |= NVMCTRL_STATUS_MASK;
    NVMCTRL->ADDR.reg = (uint32_t)addr / 2;
    NVMCTRL->CTRLA.reg = NVMCTRL_CTRLA_CMDEX_KEY | cmd;
    wait_ready();
}

void setBootProt(int v) { // Because SEEED don't bother protecting the f#cking bootloader by default, I'm doing it here.
    uint32_t *NVM_FUSES = (uint32_t *)NVMCTRL_AUX0_ADDRESS;

    uint32_t fuses[2];

    fuses[0] = NVM_FUSES[0];
    fuses[1] = NVM_FUSES[1];

    uint32_t bootprot = (fuses[0] & NVMCTRL_FUSES_BOOTPROT_Msk) >> NVMCTRL_FUSES_BOOTPROT_Pos;

    if (bootprot == v) {
        return;
    }

    fuses[0] = (fuses[0] & ~NVMCTRL_FUSES_BOOTPROT_Msk) | (v << NVMCTRL_FUSES_BOOTPROT_Pos);

    wait_ready();
    exec_cmd(NVMCTRL_CTRLA_CMD_EAR, (uint32_t *)NVMCTRL_USER);
    exec_cmd(NVMCTRL_CTRLA_CMD_PBC, (uint32_t *)NVMCTRL_USER);

    NVM_FUSES[0] = fuses[0];
    NVM_FUSES[1] = fuses[1];

    exec_cmd(NVMCTRL_CTRLA_CMD_WAP, (uint32_t *)NVMCTRL_USER);

    NVIC_SystemReset();
}

uint32_t getBootProt()
{
  uint32_t *NVM_FUSES = (uint32_t *)NVMCTRL_AUX0_ADDRESS;

    uint32_t fuses[2];

    fuses[0] = NVM_FUSES[0];
    fuses[1] = NVM_FUSES[1];

    uint32_t bootprot = (fuses[0] & NVMCTRL_FUSES_BOOTPROT_Msk) >> NVMCTRL_FUSES_BOOTPROT_Pos;
    return bootprot;
}



void getSerialChars() {
  for (int i = 0; i < INPUT_SIZE + 1; i++) {
    input[i] = ' ';
  }
  byte size = Serial.readBytes(input, INPUT_SIZE);
  input[size] = 0;
}

void getClickChar() {
  for (int i = 0; i < INPUT_SIZE + 1; i++) {
    input[i] = '0';
  }
  byte size = Serial.readBytesUntil('\n', input, 1);
  input[size] = 0;
}

void establishContact() {
  while (Serial.available() <= 0) {
    Serial.println('OSLTT');  // send a capital A
    delay(250);
  }
}


int getADCValue(int count, int pin = 0) {
  uint32_t value = 0;
  int localCounter = 0;
  while (localCounter < count) {

    value += analogRead(pin);
    localCounter++;
  }
  value /= count;
  return value;
}

long fillADCBuffer(int count, int pin = 0) {

  int localCounter = 0;
  long startTimer = micros();
  while (localCounter < count) {
    adcBuff[localCounter] = analogRead(pin);
    localCounter++;
  }
  long endTimer = micros();
  return endTimer - startTimer;
}

long fillADCBufferSlower(int count, int pin = 0) {

  int localCounter = 0;
  long startTimer = micros();
  while (localCounter < count) {
    adcBuff[localCounter] = analogRead(pin);
    delayMicroseconds(25);
    localCounter++;
  }
  long endTimer = micros();
  return endTimer - startTimer;
}

int getSingleADCValue(int pin = 0) {
  return analogRead(pin);
}

int convertHexToDec(char c) {
  if (c <= 57) {
    return c - '0';  // Convert char to int
  } else {
    return c - 55;
  }
}


void pulseLED(bool state) {
  if (state) {
    for (int i = 0; i < 255; i++) {
      analogWrite(3, i);
      delay(5);
    }
  } else {
    for (int i = 255; i > 0; i--) {
      analogWrite(3, i);
      delay(5);
    }
    analogWrite(3, 0);
  }
}

void toggleLED(bool state) {
  if (state) {
    analogWrite(3, 0xFF);
  } else {
    analogWrite(3, 0x00);
  }
}

void runTest(int sampleCount = 9000, String textType = "RES:", bool audioTest = false) {

  unsigned long clickTime = micros();
  if (inputType == 0 && sourceType == 0) {
    //Mouse.click(MOUSE_LEFT);
    Keyboard.write((char)32);
  }
  else if (inputType == 0 && sourceType == 2)
  {
    if (MouseAction == 0)
    {
      Mouse.click(MOUSE_LEFT);
    }
    else if (MouseAction == 1 || MouseAction == 3)
    {
      Mouse.move(-127, 0);
    }
    else if (MouseAction == 2 || MouseAction == 4)
    {
      Mouse.move(127, 0);
    }
    else
    {
      Keyboard.write((char)32);
    }
  }
  unsigned long start_time = micros();
  int t = start_time - clickTime;
  long timeTaken;
  if (audioTest)
  { 
    timeTaken = fillADCBufferSlower(sampleCount, 1);
  }
  else
  {
    timeTaken = fillADCBuffer(sampleCount, 0); 
  }
  toggleLED(true);
  long localStartValue = 0;
  int triggerSampleNum = 0;
  Serial.print(textType);
  Serial.print(t);
  Serial.print(",");
  Serial.print(timeTaken);
  Serial.print(",");
  Serial.print(sampleCount);
  Serial.print(",");

  for (int i = 0; i < sampleCount; i++) {
    Serial.print(adcBuff[i]);
    Serial.print(",");
  }
  Serial.println();
  if (MouseAction == 1 || MouseAction == 3) // move mouse back
  {
    Mouse.move(127, 0);
  }
  else if (MouseAction == 2 || MouseAction == 4)
  {
    Mouse.move(-127, 0);
  }
  // Serial.print("RESULT:");
  // double result = (timeTaken / sampleCount) * triggerSampleNum;
  // Serial.println(result / 1000);
  toggleLED(false);
}


void autoRunTest(bool autoRun = true, int sampleCount = 9000, int clickCount = 100, bool pretest = false) {
  if (pretest) {
    int localCounter = 0;
    int localMouseAction = MouseAction;
    MouseAction = 5; // must be spacebar
    while (input[0] != 'X' && localCounter < clickCount) {
      getSerialChars();
      runTest(sampleCount, "PRETEST:");
      localCounter++;
    }
    MouseAction = localMouseAction;
    Serial.println("PRETEST FINISHED");
    delay(1000);
    Keyboard.press(KEY_ESC);
    Keyboard.releaseAll();
  }
  else if (autoRun) {
    int localCounter = 0;
    Serial.setTimeout(100);
    while (input[0] != 'X' && localCounter < clickCount) {

      runTest(sampleCount);
      long timer1 = millis();
      getSerialChars();
      long targetTime = timer1 + (timeBetween * 1000);
      while (millis() > targetTime) { delay(1); }
      localCounter++;
    }
    Serial.println("AUTO FINISHED");
    if (directXMode) {
      Keyboard.press(KEY_ESC);
      Keyboard.releaseAll();
    }
  } else if (!autoRun) {
    runTest(sampleCount);
    Serial.println("SINGLE FIRE");
  } 
}

void runClickTest() {
  toggleLED(false);
  Serial.setTimeout(100);

  int baseline = getADCValue(500, 1);
  int baselineAdjusted = 16380 - baseline;
    baselineAdjusted *= 0.8;
    baselineAdjusted += baseline;
  Serial.print("baseline: ");
  Serial.println(baseline);
  Serial.print("baselineAdjusted: ");
  Serial.println(baselineAdjusted);
  int counter = 0;
  while (input[0] != 'X') {
    if (digitalRead(ButtonPin)) {
      input[0] = 'X';
      toggleLED(false);
    }
    if (counter == ArraySize)
    {
      counter = 0;
    }
    adcBuff[counter] = analogRead(1);
    int current = adcBuff[counter];
    counter++;
    //Serial.println(current); //debugging use only
    
    if (current > baselineAdjusted) {
      // keyboard/mouse mode. Listen for click, wait for PC to report click.
      input[0] = '0';
      Serial.println(current); // remove after debugging
      Serial.println("just testing were in the right function");
      long start = micros();
      while (input[0] != 'H' && input[0] != 'X') {
        getClickChar();
        //getSerialChars();
      }
      long end = micros();
      long time = end - start;

      Serial.print("CLICK:");
      Serial.println(time);
      toggleLED(true);
      delay(200);
      // sync clocks again
      toggleLED(false);
      delay(100);
    }
  }
  
  Serial.setTimeout(100);
  Serial.println("Clicks Finished");
  toggleLED(true);
}

void runClickTest2Pin()
{
  while (input[0] != 'X') {
    if (digitalRead(ButtonPin)) {
      input[0] = 'X';
      toggleLED(false);
    }
    
    //Serial.println(current); //debugging use only
    
    if (!digitalRead(PullDownPin)) {
      // keyboard/mouse mode. Listen for click, wait for PC to report click.
      input[0] = '0';
      
      long start = micros();
      while (input[0] != 'H' && input[0] != 'X') {
        getClickChar();
      }
      long end = micros();
      long time = end - start;

      Serial.print("CLICK:");
      Serial.println(time);
      toggleLED(true);
      delay(200);
      // sync clocks again
      toggleLED(false);
      delay(100);
    }
  }
}

void runAudioTest() {
  long start = micros();
  Serial.println("AUDIO TRIGGER");
  long end = micros();
  long timeTaken = fillADCBufferSlower(ArraySize, 1);
  Serial.print("AUDIORES:");
  Serial.print(end - start);
  Serial.print(",");
  Serial.print(timeTaken);
  Serial.print(",");
  Serial.print(ArraySize);
  Serial.print(",");

  for (int i = 0; i < ArraySize; i++) {
    Serial.print(adcBuff[i]);
    Serial.print(",");
  }
  Serial.println();
  //Serial.print("AUDIO SERIAL DELAY:");
  //Serial.println(end - start);
}
