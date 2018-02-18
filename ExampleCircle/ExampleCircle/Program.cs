using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCircle
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("radius for Circle: ");
            int radius = int.Parse(Console.ReadLine());

            Console.WriteLine("n's for Rectangle: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Rectangle r = new Rectangle(a, b);
            Circle c = new Circle(radius);


            Console.WriteLine(r);
            Console.WriteLine(c);


            Console.ReadKey();

        }
    }
}
