using System;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120,30);

            //Drawing a frame

            Walls walls = new Walls(120, 30);
            walls.Draw();

            //Drawing a snake

            Point point = new Point(4, 5, '*');
            Snake snake = new Snake(point, 3, Direction.RIGHT);
            snake.Draw();
            
            //Create the food

            FoodGenerator foodGenerator = new FoodGenerator(116, 25, '$');
            Point food = foodGenerator.CreateFood();
            food.Draw();

            while (true)
            {
                if(walls.IsHit(snake) || snake.IsHitTail())
                {
                    gameOver();
                    Console.ReadKey();
                    break;
                }
                if(snake.Eat(food))
                {
                    food = foodGenerator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }  
                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.PushKey(key.Key);
                }
            }
        }
        public static void gameOver()
        {
            Figure horizontalUp = new HorizontalLine(47, 67, 10, '=');
            Figure horizontalUp1 = new HorizontalLine(49, 49, 13, 'G');
            Figure horizontalUp2 = new HorizontalLine(50, 50, 13, ' ');
            Figure horizontalUp3 = new HorizontalLine(51, 51, 13, 'A');
            Figure horizontalUp6 = new HorizontalLine(52, 52, 13, ' ');
            Figure horizontalUp7 = new HorizontalLine(53, 53, 13, 'M');
            Figure horizontalUp8 = new HorizontalLine(54, 54, 13, ' ');
            Figure horizontalUp9 = new HorizontalLine(55, 55, 13, 'E');
            Figure horizontalUp0 = new HorizontalLine(56, 56, 13, ' ');
            Figure horizontalUp11 = new HorizontalLine(57, 57, 13, ' ');
            Figure horizontalUp12 = new HorizontalLine(58, 58, 13, ' ');
            Figure horizontalUp13 = new HorizontalLine(59, 59, 13, 'O');
            Figure horizontalUp14 = new HorizontalLine(60, 60, 13, ' ');
            Figure horizontalUp15 = new HorizontalLine(61, 61, 13, 'V');
            Figure horizontalUp16 = new HorizontalLine(62, 62, 13, ' ');
            Figure horizontalUp17 = new HorizontalLine(63, 63, 13, 'E');
            Figure horizontalUp18 = new HorizontalLine(64, 64, 13, ' ');
            Figure horizontalUp19 = new HorizontalLine(65, 65, 13, 'R');
            Figure horizontalDown = new HorizontalLine(47, 67, 16, '=');

            horizontalUp.Draw();
            horizontalUp1.Draw();
            horizontalUp2.Draw();
            horizontalUp3.Draw();
            horizontalUp6.Draw();
            horizontalUp7.Draw();
            horizontalUp8.Draw();
            horizontalUp9.Draw();
            horizontalUp0.Draw();
            horizontalUp11.Draw();
            horizontalUp12.Draw();
            horizontalUp13.Draw();
            horizontalUp14.Draw();
            horizontalUp15.Draw();
            horizontalUp16.Draw();
            horizontalUp17.Draw();
            horizontalUp18.Draw();
            horizontalUp19.Draw();
            horizontalDown.Draw();
        }
    }
}