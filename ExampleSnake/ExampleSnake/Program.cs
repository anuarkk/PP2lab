﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(30, 20);

            Snake snake = new Snake();
            food food = new food();


            while (true)
            {
                Console.ResetColor();
                snake.Draw();
                food.Draw();

                ConsoleKeyInfo btn = Console.ReadKey();
                switch (btn.Key)
                {
                    case ConsoleKey.UpArrow:
                        snake.Move(0, -1);
                        break;
                    case ConsoleKey.DownArrow:
                        snake.Move(0, 1);
                        break;
                    case ConsoleKey.LeftArrow:
                        snake.Move(-1, 0);
                        break;
                    case ConsoleKey.RightArrow:
                        snake.Move(1, 0);
                        break;
                }
                if (snake.body[0].x > 69)
                    snake.body[0].x = 0;
                if (snake.body[0].x < 0)
                    snake.body[0].x = 69;
                if (snake.Eat(food))
                {
                    food.SetRandomPosition();
                }


            }
        }
    }
}
