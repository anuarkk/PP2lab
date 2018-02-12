using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSnake
{
    class food
    {
        public Point location;
        public char sign;
        public ConsoleColor color;

        public food()
        {
            color = ConsoleColor.Green;
            sign = '&';
            location = new Point(14, 7);
        }
        public void SetRandomPosition()
        {
            int x = new Random().Next(0, 20);
            int y = new Random().Next(0, 20);

            location = new Point(x, y);
        }
        public void Draw()
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(location.x, location.y);
            Console.Write(sign);
        }
    }
}
