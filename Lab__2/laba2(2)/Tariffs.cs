using System;
using System.Collections.Generic;
using System.Text;
using laba2_2_;

namespace Tariffs
{
    class Tariff1 : Tariff
    {
        static string type = "t1";
        public Tariff1() : base() { }
        public Tariff1(string name, int traffic, int numOfClient, int cost) : base(name, traffic, numOfClient, cost) { }
    }
    class Tariff2 : Tariff
    {
        static string type = "t2";
        public Tariff2() : base() { }
        public Tariff2(string name, int traffic, int numOfClient, int cost) : base(name, traffic, numOfClient, cost) { }
    }
    class Tariff3 : Tariff
    {
        static string type = "t3";
        public Tariff3() : base() { }
        public Tariff3(string name, int traffic, int numOfClient, int cost) : base(name, traffic, numOfClient, cost) { }
    }

}
