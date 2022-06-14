using System;
using System.Collections.Generic;
using System.Text;
using Tariffs;

namespace laba2_2_
{
   class cvar
    {
        public List<Tariff> tr = new List<Tariff>();
        public void Add()
        {
            Console.WriteLine("1 - t1, 2 - t2, 3 - t3");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i == 1)
            {
                tr.Add(new Tariff1());
            }
            else if (i == 2)
            {
                tr.Add(new Tariff2());
            }
            else
            {
                tr.Add(new Tariff3());
            }
        }
        public void Add(int i, string name, int traffic, int numOfClient, int cost)
        {
            if (i == 1)
            {
                tr.Add(new Tariff1(name, traffic, numOfClient, cost));
            }
            else if (i == 2)
            {
                tr.Add(new Tariff2(name, traffic, numOfClient, cost));
            }
            else
            {
                tr.Add(new Tariff3(name, traffic, numOfClient, cost));
            }
        }

        public int Compare(Tariff e1, Tariff e2)
        {
            if (e1.traffic == e2.traffic) return 0;
            else if (e1.traffic >= e2.traffic) return 1;
            else return -1;
        }

        public void Sort()
        {
            tr.Sort(Compare);
            Console.WriteLine("Tariffs sorted by traffic volume:");
            for (int i = 0; i < tr.Count; i++)
            {
                Console.WriteLine($"{tr[i].name} : {tr[i].traffic}");
            }
        }

        public void InDiapasone(int min1, int max1, int min2, int max2)
        {
            Console.WriteLine($"In diapasone from {min1} to {max1} by traffic and in {min2} to {max2} by cost:");
            for (int i = 0; i < tr.Count; i++)
            {
                if (tr[i].traffic >= min1 && tr[i].traffic <= max1 && tr[i].cost >= min2 && tr[i].cost <= max2)
                {
                    Console.WriteLine($"{tr[i].name}: {tr[i].traffic} - traffic, {tr[i].cost} - cost");
                }
            }
        }
    }
}
