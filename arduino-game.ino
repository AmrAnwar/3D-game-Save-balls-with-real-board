//Analog read pins
const int xPin = 0;const int yPin = 1;const int zPin = 2;
//The minimum and maximum values that came from
int minVal = 265;int maxVal = 402;
//values of angles
int x,y,z;
void setup(){Serial.begin(9600); }
void loop(){//read the analog values from the accelerometer
  int xRead = analogRead(xPin);
  int yRead = analogRead(yPin);
  int zRead = analogRead(zPin);
  //convert read values to degrees -90 to 90 - Needed for atan2
  int xAng = map(xRead, minVal, maxVal, -90, 90);
  int yAng = map(yRead, minVal, maxVal, -90, 90);
  int zAng = map(zRead, minVal, maxVal, -90, 90);
  //Caculate 360deg values like so: atan2(-yAng, -zAng)
  //atan2 outputs the value of -π to π (radians)
  //We are then converting the radians to degrees
  x = RAD_TO_DEG * (atan2(-yAng, -zAng) + PI);
  y = RAD_TO_DEG * (atan2(-xAng, -zAng) + PI);
  z = RAD_TO_DEG * (atan2(-yAng, -xAng) + PI);
  if(x<=360 && x>180){x -=360;}
  if(y<=360 && y>180){y -=360;}
  if(z<360 && z>180){z -=360;}
 //Output the caculations
 Serial.print(x);Serial.print(",");Serial.println(y);delay(100); // we will use the x and y angles only
  }
