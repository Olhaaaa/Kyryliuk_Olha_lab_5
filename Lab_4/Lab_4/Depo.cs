using System;
using System.Collections.Generic;
using System.Text;
using TansportType;

namespace Lab_4
{
    class Depo
    {
       
        public List < Transport> transport = new List< Transport>();

        public void Add( string name, double speed, double cost)
        {
            if(name=="train")
            {
                transport.Add(new Train(speed, cost));
            }
            else if (name =="airplane")
            {
                transport.Add(new Airplane(speed, cost));
            }
            else if (name=="car")
            {
                transport.Add(new Car(speed, cost));
            }
            else if (name =="bus")
            {
                transport.Add(new Bus (speed, cost));
            }
            else
            {
                transport.Add(new Helicopter(speed, cost));
            }
        }

        public void Choose( )
        {
            Console.WriteLine("Оберіть вид транспорту: ");
            string choose = Console.ReadLine();
            switch (choose)
            {
                case "train":
                    transport[0].Length();
                    transport[0].Price();
                    transport[0].Time();
                    break;

                case "bus":
                    transport[1].Length();
                    transport[1].Price();
                    transport[1].Time();
                    break;
                case "car":
                    transport[3].Length();
                    transport[3].Price();
                    transport[3].Time();
                    break;
                case "airplane":
                    transport[4].Length();
                    transport[4].Price();
                    transport[4].Time();
                    break;
                case "helicopter":
                    transport[2].Length();
                    transport[2].Price();
                    transport[2].Time();
                    break;

            }
        }
    }
}
