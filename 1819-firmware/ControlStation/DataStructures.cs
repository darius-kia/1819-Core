﻿namespace ControlStation
{
    public struct ESCStatus
    {
        public double Temperature, Speed;
        public int RPM;
        public bool IsOvertemp
        {
            get
            {
                return Temperature > 45;
            }
        }
    }
    public struct Orientation
    {
        public double Heading, Pitch, Roll;
        public Orientation(double Heading, double Pitch, double Roll)
        {
            this.Heading = Heading;
            this.Pitch = Pitch;
            this.Roll = Roll;
        }
    }
    public struct ROVStatus
    {
        public bool Connected, Armed;
        public int ErrorCode, LoopCounter;
        public double Voltage;
        public string ErrorString
        {
            get
            {
                switch(ErrorCode)
                {
                    case 0:
                        return "All systems go";
                    case 1:
                        return "IMU failure";
                    case 2:
                        return "Communication failure";
                    case 3:
                        return "ESC failure";
                    case 4:
                        return "Pressure sensor failure";
                    default:
                        return "Welllllllll, s&*t. Unknown error " + ErrorCode;
                }
            }
        }
        public bool IsUndervolt
        {
            get
            {
                return (Voltage < 7);
            }
        }
    }
}