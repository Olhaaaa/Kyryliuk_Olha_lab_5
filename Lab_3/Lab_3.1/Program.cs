using System;
using System.Collections.Generic;

namespace Lab_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfInt = new List<int>();
            Console.WriteLine("Enter the number of list items: ");
            int amount;
            amount = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();

            for (int i = 0; i < amount; i++)
            {
                listOfInt.Add(random.Next(-100, 100));
            }
            for (int i = 0; i < amount; i++)
            {
                Console.Write(listOfInt[i] + " ");
            }
            Console.WriteLine("Sort...");
            for (int i = 0;i<amount-1;i++)
            {
                for(int j=i+1;j>0;j--)
                {
                    if(listOfInt[j-1]<listOfInt[j] && !((listOfInt[j - 1] > 0 && listOfInt[j] > 0) || ((listOfInt[j - 1] < 0 && listOfInt[j] < 0))))
                    {
                        int temp = listOfInt[j - 1];
                        listOfInt[j - 1] = listOfInt[j];
                        listOfInt[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted list:");
            for (int i = 0; i < amount; i++)
            {
                Console.Write(listOfInt[i] + " ");
            }
        }
    }
}
