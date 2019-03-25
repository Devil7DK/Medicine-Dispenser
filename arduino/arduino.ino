#include <Servo.h>

#define S1 2
#define S2 3
#define S3 4
#define IR 5

Servo s1;
Servo s2;
Servo s3;
int hand = HIGH;

boolean hand_placed = false;

String command;

void setup() {
  Serial.begin(9600);
  pinMode(IR, INPUT);

  s1.attach(S1);
  s2.attach(S2);
  s3.attach(S3);

  s1.write(180);
  s2.write(180);
  s3.write(180);
  delay(3000);
}

void loop() {
  hand = digitalRead(IR);
  if(hand == LOW && hand_placed == false){
    hand_placed = true;
    Serial.println("HP");
  } else if (hand == HIGH && hand_placed == true) { 
    hand_placed = false;
    Serial.println("HR");
  }

  while (Serial.available()) {
    delay(3);
    if (Serial.available() > 0) {
      char c = Serial.read();
      command += c;
    } 
  }

  if (command.length() > 0 && countChar(command, ':') == 2) {
    int A = 0;
    int B = 0;
    int C = 0;
    int i = -1;

    char *p = command.c_str();
    char *str;
    while ((str = strtok_r(p, ":", &p)) != NULL) {
      i += 1;

      switch (i) {
        case 0:
          A = atoi(str);
          break;
        case 1:
          B = atoi(str);
          break;
        case 2:
          C = atoi(str);
          break;
      }
    }

    dispense(A, B, C);
    Serial.println("DS");
    command = "";
  } 
  
  delay(500);
}

void dispense(int A, int B, int C) {
  int D = 0;
  Serial.println(A);
  Serial.println(B);
  Serial.println(C);
  while (A > 0 || B > 0 || C > 0) {
    if (A > 0) s1.write(0);
    if (B > 0) s2.write(0);
    if (C > 0) s3.write(0);
    delay(1300);

    if (A > 0) {
      s1.write(180);
      D += 1;
      A -= 1;
    }
    if (B > 0) {
      s2.write(180);
      D += 1;
      B -= 1;
    }
    if (C > 0) {
      s3.write(180);
      D += 1;
      C -= 1;
    }

    delay(1300);
  }
}

int countChar(String string, char c) {
  int count = 0;
  for (int i = 0; i < string.length(); i++) {
    if (string.charAt(i) == c) count++;
  }
  return count;
}
