using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDemoApplication
{
    class season
    {
        static void Main()
        {
            Console.WriteLine("Enter the month ");
            int month = int.Parse(Console.ReadLine());
            if (month >= 3 && month <= 5)
            {
                Console.WriteLine("Spring");
            }
            else if (month >= 6 && month <= 8)
            {
                Console.WriteLine("Summer");
            }
            else if (month >= 9 && month <= 11)
            {
                Console.WriteLine("Autumn");
            }
            else if (month == 12 || month == 1 || month == 2)
            {
                Console.WriteLine("Winter");
            }
            else
            {
                Console.WriteLine("Invalid Month ");
            }
        }
    }
}
