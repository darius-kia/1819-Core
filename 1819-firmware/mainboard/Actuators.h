Arduino_I2C_ESC *escs[NUM_ESCS];

const uint8_t dir1Pins[] = DIR1_PINS;
const uint8_t dir2Pins[] = DIR2_PINS;

void initESCs() {
	uint8_t addresses[] = ESC_ADDRESSES;
	for (int i = 0; i < NUM_ESCS; i++) {
		Wire.beginTransmission(addresses[i]); //check if ESC at this address available
		uint8_t err = Wire.endTransmission();
		if (err > 0) {
			error = ESC_FAILURE;
			return;
		}
		escs[i] = new Arduino_I2C_ESC(addresses[i], NUM_POLES); //T100 has 12 poles. Is the default of 6 correct?
													//This will affect the RPM value
	}
}

void writeESCs() {
	for (int i = 0; i < NUM_ESCS; i++) {
		//convert pairs of bytes into 16-bit int for control of ESC
		escs[i]->set(rxData.data[i * 2 + 1] << 8 | rxData.data[i * 2]);
	}
}

void initTools() {
	pinMode(LED_CTRL, OUTPUT);
	pinMode(RLY1_CTRL, OUTPUT);
	pinMode(RLY2_CTRL, OUTPUT);
	for (int i = 0; i < NUM_TOOLS; i++) {
		pinMode(dir1Pins[i], OUTPUT);
		pinMode(dir2Pins[i], OUTPUT);
	}
}

/*
Sets manipulator speed of motor controlled by pins dir1 & dir2
to val. 0 is full reverse, 255 is full forward, and 128 is stopped
*/
void setManipulator(uint8_t val, uint8_t dir1, uint8_t dir2) {
	if (val > 128) {
		analogWrite(dir1, (val - 128) * 2);
		digitalWrite(dir2, LOW);
	}
	else if (val < 128) {
		analogWrite(dir1, val * 2);
		digitalWrite(dir2, HIGH);
	}
	else {
		digitalWrite(dir1, LOW);
		digitalWrite(dir2, LOW);
	}
}

void writeTools() {
	for (int i = 0; i < NUM_TOOLS; i++) {
		setManipulator(rxData.data[i], dir1Pins[i], dir2Pins[i]);
	}
}

void initStatus() {
	error = ALL_SYSTEMS_GO;
	status = DISCONNECTED;
}

void resetBoard() {
	digitalWrite(A2, LOW); //connected to RESET pin
	while (true);
}

void writeStatus() {
	if (status != rxData.data[0]) { //only change if needed
		switch (rxData.data[0]) {
			case DISARMED:
				if (status == ARMED) //avoids going to disarmed state
					status = DISARMED; //when not connected
				break;
			case ARMED:
				if (status == DISARMED) //ditto ^
					status = ARMED;
				break;
			case REBOOT:
				resetBoard();
				break;
		}
	}
}

//call to stop all movement of actuators
void emergencyStop() {
	for (int i = 0; i < NUM_ESCS; i++) {
		escs[i]->set(0);
	}
	for (int i = 0; i < NUM_TOOLS; i++) {
		setManipulator(128, dir1Pins[i], dir2Pins[i]);
	}
}