using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // WHY WE ARE GOING TO USE THE COLLECTIONS ?

            //string[] names = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);

            //names = new string[5];
            //names[4] = "Sezer";
            //Console.WriteLine(names[3]);
            //Console.WriteLine(names[4]);

            // The answer to the question is in above and in below :)

            List<string> names = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);

            names.Add("Sezer");
            Console.WriteLine(names[3]);
            Console.WriteLine(names[4]);
        }
    }
}
