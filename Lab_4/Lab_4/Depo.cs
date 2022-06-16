using System;
using System.Collections.Generic;
using System.Text;
using TansportType;

namespace Lab_4
{
    class Depo
    {
       
        public Dictionary<string, Transport> transport = new Dictionary<string, Transport>();

        public void Add( string name, double speed, double cost)
        {
            if(name=="train")
            {
                transport.Add("train",new Train(speed, cost));
            }
            else if (name =="airplane")
            {
                transport.Add("airplane",new Airplane(speed, cost));
            }
            else if (name=="car")
            {
                transport.Add("car",new Car(speed, cost));
            }
            else if (name =="bus")
            {
                transport.Add("bus",new Bus (speed, cost));
            }
            else
            {
                transport.Add("helicopter",new Helicopter(speed, cost));
            }
        }

        public void Choose()
        {
            Console.WriteLine("Оберіть вид транспорту: ");
            string choose = Console.ReadLine();
            switch (choose)
            {
                case "train":
                    transport["train"].Length();
                    transport["train"].Price();
                    transport["train"].Time();
                    break;

                case "bus":
                    transport["bus"].Length();
                    transport["bus"].Price();
                    transport["bus"].Time();
                    break;
                case "car":
                    transport["car"].Length();
                    transport["car"].Price();
                    transport["car"].Time();
                    break;
                case "airplane":
                    transport["airplane"].Length();
                    transport["airplane"].Price();
                    transport["airplane"].Time();
                    break;
                case "helicopter":
                    transport["helicopter"].Length();
                    transport["helicopter"].Price();
                    transport["helicopter"].Time();
                    break;

            }
        }
    }
}
