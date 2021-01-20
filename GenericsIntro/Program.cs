using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();

            names.Add("Sezer");
            Console.WriteLine(names.Length);

            names.Add("Kerem");
            Console.WriteLine(names.Length);

            foreach (var name in names.Items)
            {
                Console.WriteLine(name);
            }
        }
    }
}
