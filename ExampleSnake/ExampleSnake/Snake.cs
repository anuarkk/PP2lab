using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSnake
{
    class Snake
    {
        public List<Point> body;
        public char sign;
        public ConsoleColor color;

        public Snake()
        {
            sign = 'o';
            color = ConsoleColor.Red;
            body = new List<Point>();

            body.Add(new Point(9, 7));
            body.Add(new Point(8, 7));
            body.Add(new Point(7, 7));
        }
        public void Move(int dx, int dy)
        {
            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;

            }
            body[0].x = body[0].x + dx;
            body[0].y = body[0].y + dy;
        }
        public bool Eat(food food)
        {
            if (body[0].x == food.location.x
                && body[0].y == food.location.y)
            {
                body.Add(new Point(body[body.Count - 1].x, body[body.Count - 1].y));
                return true;
            }
            return false;

        }

        public void Draw()
        {
            for (int i = 0; i < body.Count; i++)
            {
                Console.ForegroundColor = (i == 0) ? ConsoleColor.Red : color;
                Console.SetCursorPosition(body[i].x, body[i].y);
                Console.Write(sign);
            }
        }
    }
}
