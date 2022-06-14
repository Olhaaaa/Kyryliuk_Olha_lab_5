using System;
using Tariffs;

namespace laba2_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            cvar c = new cvar();
            c.Add(1, "t1", 1000, 3000, 300);
            c.Add(2, "t2", 1500, 5000, 500);
            c.Add(3, "t3", 500, 2000, 150);
            c.Sort();
            c.InDiapasone(700, 1200, 100, 400);
            c.tr[0].NumOfClient();
            c.tr[1].NumOfClient();
            c.tr[2].NumOfClient();
        }
    }
}
