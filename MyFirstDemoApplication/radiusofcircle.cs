using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDemoApplication
{
    class radiusofcircle
    {
        static void Main()
        {
            Console.WriteLine("Enter RADIUS of circle");
            float r = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.PI * r * r);
        }
    }
}
