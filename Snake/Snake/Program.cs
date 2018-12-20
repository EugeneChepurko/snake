using System;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120,30);

            Figure horizontalLineUp = new HorizontalLine(0, 118, 0, '+');
            Figure horizontalLineDown = new HorizontalLine(0, 118, 27, '+');
            Figure leftLine = new VerticalLine(0, 27, 0, '+');
            Figure rightLine = new VerticalLine(0, 27, 118, '+');

            horizontalLineUp.Draw();
            horizontalLineDown.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Point point = new Point(4, 5, '*');
            Figure Fsnake = new Snake(point, 3, Direction.RIGHT);
            Fsnake.Draw();
            Snake snake = (Snake)Fsnake;

            FoodGenerator foodGenerator = new FoodGenerator(116, 25, '$');
            Point food = foodGenerator.CreateFood();
            food.Draw();

            while (true)
            {
                if(snake.Eat(food))
                {
                    food = foodGenerator.CreateFood();
                    food.Draw();
                }
                else
                    snake.Move();
                Thread.Sleep(200);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.PushKey(key.Key);
                }
            }
        }
    }
}