using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            StartGame();
        }

        private static void StartGame()
        {
            Console.SetBufferSize(120, 30);
            Score score = new Score();

            //Drawing a frame

            Walls walls = new Walls(120, 30);
            walls.Draw();

            //Drawing a snake

            Point point = new Point(4, 5, '*');
            Snake snake = new Snake(point, 3, Direction.RIGHT);
            snake.Draw();

            //Create the food

            FoodGenerator foodGenerator = new FoodGenerator(116, 25, '$');
            Point food = foodGenerator.CreateFood(snake);
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    if (Score.score > Score.maxScore)
                        Score.maxScore = Score.score;

                    score.PrintScore();

                    while (true)
                    {
                        if (Console.KeyAvailable)
                        {
                            ConsoleKeyInfo key = Console.ReadKey();
                            if (key.Key == ConsoleKey.Y)
                            {
                                Console.Clear();
                                Score.score = 0;
                                StartGame();
                            }
                            else if (key.Key == ConsoleKey.N)
                                Environment.Exit(0);
                            else
                                continue;                         
                        }
                    }
                }
                if (snake.Eat(food))
                {
                    food = foodGenerator.CreateFood(snake);
                    food.Draw();
                }
                else
                    food.Draw();
                    snake.Move();

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.PushKey(key.Key);
                }
            }
        }
    }
}
