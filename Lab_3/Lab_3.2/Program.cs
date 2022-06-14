using System;
using System.Collections.Generic;
using System.Text.Json;
using Newtonsoft.Json;
using System.IO;

namespace Lab_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Amount;
            int Number;

            Console.WriteLine("Введіть кількість елементів словника:");
            Amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть ключ, значення після якого будуть виведені: ");
            Number = Convert.ToInt32(Console.ReadLine());

        Dictionary<int, int> dictionary = new Dictionary<int, int>();

        Random random = new Random();

            for (int i = 0; i < Amount; i++)
            {
                dictionary.Add(i,random.Next(-100, 100));
            }
            for (int i = 0; i < Amount; i++)
            {
                Console.Write(dictionary[i] + " ");
            }
      

        Dictionary<int, int> choosendictionary = new Dictionary<int, int>();
        
            Console.WriteLine("Обрані елементи:");

            if (Number < Amount)
            {
                foreach (KeyValuePair<int, int> el in dictionary)
                {
                    if (el.Key >= Number)
                    {
                        choosendictionary.Add(el.Key, el.Value);
                        Console.WriteLine("Key: " + el.Key + " Value: " + el.Value);
                    }

                }
            }
            else
            {
                Console.WriteLine("null");
            }
                      
           

            string str = JsonConvert.SerializeObject(choosendictionary);
            File.WriteAllText("D:\\Visual Studio.term2\\Lab_3\\Dictionary.json", str);
    }

}
    }

