using System;
using System.Collections.Generic;
using System.Text;
using Lab_4;


namespace TansportType
{
    class Airplane : Transport
    {
        static public string name = "airplane";
        public Airplane(double speed, double cost) : base(speed, cost) { }

    }

    class Train : Transport
    {
        static public string name = "train";
        public Train (double speed, double cost) : base(speed, cost) { }

    }
    class Car : Transport
    {
        static public string name = "car";
        public Car (double speed, double cost) : base(speed, cost) { }
    }

    class Bus : Transport
    {
        static public string name = "bus";
        public Bus(double speed, double cost) : base(speed, cost) { }
    }
    class Helicopter : Transport 
    {
        static public string name = "helicopter";
        public Helicopter(double speed, double cost) : base(speed, cost) { }
    }


}
