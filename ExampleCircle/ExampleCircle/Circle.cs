using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCircle
{
    class Circle
    {
        public int radius;
        public double area;
        public int diameter;
        public double circumference;

       

        public Circle(int radius)
        {
            this.radius = radius;
            findArea();
            findCircumference();
            findDiameter();
        }
        public void findArea()
        {
            area = Math.PI * radius * radius;
        }
        public void findDiameter()
        {
            diameter = radius * 2;

        }
        public void findCircumference()
        {

            circumference = 2 * radius * Math.PI;
            
        }
        public override string ToString()
        {
            return "\nArea of Circle = " + area + "\nDiameter of Circle = " + diameter + "\nCircumference of Circle = " + circumference;
        }
    }
}
