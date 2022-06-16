﻿using System;
using System.Collections.Generic;
using System.Text;


namespace Lab_4
{
    abstract class Transport
    {
        public double speed;     
        public double cost;       
        public double length;
        public Transport(double speed, double cost)
        {
            this.speed = speed;
            this.cost = cost;
        }
        public void Length()
        {
            Console.WriteLine("Введіть довжину маршруту:");
            length = Convert.ToDouble(Console.ReadLine());            
        }
        public void Price()
        {
            Console.WriteLine($"Вартість поїздки: {cost * length}");
        }
        public void Time()
        {            
            Console.WriteLine($"Час подорожі:{Math.Round(length/speed,2)} год. ") ;
        }

    }
}
