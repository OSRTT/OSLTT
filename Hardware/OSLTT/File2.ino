// Setup and helper functions


void getSerialChars() {
  for (int i = 0; i < INPUT_SIZE + 1; i++) {
    input[i] = ' ';
  }
  byte size = Serial.readBytes(input, INPUT_SIZE);
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
    delayMicroseconds(20);
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
    Mouse.click(MOUSE_LEFT);
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
    // if (i < 100) {
    //   localStartValue += adcBuff[i];
    // } else if (i == 100) {
    //   localStartValue /= 100;
    // } else {
    //   if (adcBuff[i] > (localStartValue * 2) && triggerSampleNum == 0) {
    //     triggerSampleNum = i;
    //   }
    // }
  }
  Serial.println();
  // Serial.print("RESULT:");
  // double result = (timeTaken / sampleCount) * triggerSampleNum;
  // Serial.println(result / 1000);
  toggleLED(false);
}


void autoRunTest(bool autoRun = true, int sampleCount = 9000, int clickCount = 100, bool pretest = false) {
  if (autoRun) {
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
  } else if (pretest) {
    int localCounter = 0;
    while (input[0] != 'X' && localCounter < clickCount) {
      getSerialChars();
      runTest(sampleCount, "PRETEST:");
      localCounter++;
    }
    Serial.println("PRETEST FINISHED");
    delay(1000);
    Keyboard.press(KEY_ESC);
    Keyboard.releaseAll();
  }
}

void runClickTest() {
  toggleLED(false);
  Serial.setTimeout(1);
  int baseline = getADCValue(500, 1);
  while (input[0] != 'X') {
    if (digitalRead(ButtonPin)) {
      input[0] = 'X';
      toggleLED(false);
    }
    int current = getSingleADCValue(1);
    int baselineAdjusted = 16380 - baseline;
    baselineAdjusted *= 0.5;
    if (current > (baseline + baselineAdjusted)) {
      // keyboard/mouse mode. Listen for click, wait for PC to report click.
      input[0] = '0';
      long start = micros();
      while (input[0] != 'H') {
        getSerialChars();
      }
      long end = micros();
      long time = end - start;

      Serial.print("CLICK:");
      Serial.println(time / 1000);
      toggleLED(true);
      delay(100);
      toggleLED(false);
    }
  }
  Serial.setTimeout(100);
  Serial.println("Clicks Finished");
  toggleLED(true);
}

void runAudioTest() {
  long start = micros();
  Serial.println("AUDIO TRIGGER");
  long end = micros();
  long timeTaken = fillADCBufferSlower(14000, 1);
  Serial.print("AUDIORES:");
  Serial.print(end - start);
  Serial.print(",");
  Serial.print(timeTaken);
  Serial.print(",14000,");

  for (int i = 0; i < 14000; i++) {
    Serial.print(adcBuff[i]);
    Serial.print(",");
  }
  Serial.println();
  //Serial.print("AUDIO SERIAL DELAY:");
  //Serial.println(end - start);
}
