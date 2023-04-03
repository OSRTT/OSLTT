// Definitions, libraries


#define INPUT_SIZE 2


int LEDPin = 3;    // first analog sensor
int PullDownPin = 4;   // second analog sensor
int ButtonPin = 6;    // digital sensor
int inByte = 0;         // incoming serial byte


uint16_t adcBuff[14000];
 
float firmwareVersion = 0.1;

int inputType = 0; // 0 = button, 1 = audio, 2 = pin trigger

int shotCount = 50;

char input[INPUT_SIZE + 1];

bool LEDState = false;