using System;
namespace MyFirstDemoApplication
{
    class billgeneration

    {
        static void Main()
        {
            int sum;
            Console.WriteLine("Enter no of pizzas bought: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter no of puffs bought: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter no of cool drinks bought: ");
            int c = int.Parse(Console.ReadLine());
            sum = (a * 100) + (b * 20) + (c * 10);
            Console.WriteLine("Bill Details");
            Console.WriteLine("No of pizzas: " + a);
            Console.WriteLine("No of puffs: " + b);
            Console.WriteLine("No of cooldrinks: " + c);
            Console.WriteLine("Total Price " + sum);
        }
    }
}
