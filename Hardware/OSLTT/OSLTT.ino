  // Definitions, libraries
#include <Mouse.h>
#include <Keyboard.h>

#define INPUT_SIZE 9

#define ArraySize 12000

int LEDPin = 3; //19   // first analog sensor
int PullDownPin = 4; //16  // second analog sensor
int ButtonPin = 6;  //2  // digital sensor
int inByte = 0;         // incoming serial byte
int PullUpPin = 9;      // CS Only
int AGain = 7;          // CS Only

uint16_t adcBuff[ArraySize];
 
float firmwareVersion = 1.6;

int inputType = 0; // 0 = button, 1 = audio, 2 = pin trigger

int sensorType = 0; // 0 = light, 1 = audio

int sourceType = 0; // 0 = directX, 1 = mouse/keyboard, 2 = game/external, 3 = audio clip

int shotCount = 100;

double timeBetween = 0.5;

bool autoClick = true;

int MouseAction = 0; // 0 = left click, 1 = move left, 2 = move right

bool directXMode = true;

char input[INPUT_SIZE + 1];

bool LEDState = false;

bool InterruptFlag = false;
int InterruptCount = 0;
bool PullDownInterruptFlag = false;

int micBaseline = 16000;
