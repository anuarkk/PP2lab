using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCircle
{
    class Rectangle
    {
        private int perimeter;
        private int area;
        private int a;
        private int b;

        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
            findArea();
            findPerimeter();
        }

        public void findPerimeter()
        {
            perimeter = (a + b) * 2;

        }
        public void findArea()
        {
            area = a * b;

        }
        public override string ToString()
        {
            return "Perimeter= " + perimeter + "\nArea= " + area; 
        }
    }
}
