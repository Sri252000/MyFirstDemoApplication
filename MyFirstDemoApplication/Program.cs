using System;

namespace MyFirstDemoApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two values");
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            int x = int.Parse(s1);
            int y = int.Parse(s2);
            Console.WriteLine(x + y);
        }
    }
}

