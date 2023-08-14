  // Definitions, libraries
#include <Mouse.h>
#include <Keyboard.h>

#define INPUT_SIZE 8


int LEDPin = 3; //19   // first analog sensor
int PullDownPin = 4; //16  // second analog sensor
int ButtonPin = 6;  //2  // digital sensor
int inByte = 0;         // incoming serial byte


uint16_t adcBuff[12000];
 
float firmwareVersion = 0.85;

int inputType = 0; // 0 = button, 1 = audio, 2 = pin trigger

int sensorType = 0; // 0 = light, 1 = audio

int sourceType = 0; // 0 = directX, 1 = mouse/keyboard, 2 = game/external, 3 = audio clip

int shotCount = 100;

double timeBetween = 0.5;

bool autoClick = true;

bool directXMode = true;

char input[INPUT_SIZE + 1];

bool LEDState = false;
