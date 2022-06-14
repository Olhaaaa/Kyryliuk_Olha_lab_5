using System;
using System.Collections.Generic;
using System.Text;

namespace laba2_2_
{
    abstract class Tariff
    {
        public string name;
        public int traffic;
        public int numOfClient;
        public int cost;
        public Tariff()
        {
            Console.WriteLine("Enter a name of tariff");
            name = Console.ReadLine();
            Console.WriteLine("Enter a traffic of tariff");
            traffic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number of clients of tariff");
            numOfClient = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a cost of tariff");
            cost = Convert.ToInt32(Console.ReadLine());
        }
        public Tariff(string name, int traffic, int numOfClient, int cost)
        {
            this.name = name;
            this.traffic = traffic;
            this.numOfClient = numOfClient;
            this.cost = cost;
        }
        public void NumOfClient()
        {
            Console.WriteLine($"Traffic {name} has {numOfClient} client");
        }
      
    }
}
