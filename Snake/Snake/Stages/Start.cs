using System;

namespace Snake.Stages
{
    class Start
    {
        public Start(){}
        public void StartStage_0()
        {
            //Drawing a frame
            Stage_0 walls = new Stage_0(120, 30);
            walls.Draw();

            //Drawing a snake
            Score score = new Score();

            Point point = new Point(4, 5, '*');
            Snake snake = new Snake(point, 3, Direction.RIGHT);
            snake.SnakeSpeed();
            snake.Draw();

            //Create the food
            FoodGenerator foodGenerator = new FoodGenerator(120, 30, '$');
            Point food = foodGenerator.CreateFood(snake);
            food.Draw();

            while (Score.score != 2)
            {
                //Show game info
                snake.SnakeSpeed();
                score.ShowScore();

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
                                StartStage_0();
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
                {
                    food.Draw();
                    snake.Move();
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.PushKey(key.Key);
                }
            }
            StartStage_1();
        }
        public void StartStage_1()
        {
            Score score = new Score();

            Console.Clear();
            Console.SetCursorPosition(45, 10);
            Console.WriteLine("======================");
            Console.SetCursorPosition(48, 12);
            Console.WriteLine("L E V E L   2");
            Console.SetCursorPosition(45, 14);
            Console.WriteLine("======================");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            //Drawing a frame
            Stage_1 walls = new Stage_1(120, 30);
            walls.Draw();

            //Drawing a snake        
            Point point = new Point(4, 5, '*');
            Snake snake = new Snake(point, 3, Direction.RIGHT);
            snake.SnakeSpeed();
            snake.Draw();

            //Create the food
            FoodGenerator foodGenerator = new FoodGenerator(120, 30, '$');
            Point food = foodGenerator.CreateFood(snake);
            food.Draw();

            while (Score.score != 4)
            {
                //Show game info
                snake.SnakeSpeed();
                score.ShowScore();

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
                                StartStage_0();
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
                {
                    food.Draw();
                    snake.Move();
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.PushKey(key.Key);
                }
            }
            StartStage_2();
        }

        public void StartStage_2()
        {
            Score score = new Score();

            Console.Clear();
            Console.SetCursorPosition(45, 10);
            Console.WriteLine("======================");
            Console.SetCursorPosition(48, 12);
            Console.WriteLine("L E V E L   3");
            Console.SetCursorPosition(45, 14);
            Console.WriteLine("======================");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            //Drawing a frame
            Stage_2 walls = new Stage_2(120, 30);
            walls.Draw();

            //Drawing a snake
            Point point = new Point(4, 5, '*');
            Snake snake = new Snake(point, 3, Direction.RIGHT);
            snake.SnakeSpeed();
            snake.Draw();

            //Create the food
            FoodGenerator foodGenerator = new FoodGenerator(120, 30, '$');
            Point food = foodGenerator.CreateFood(snake);
            food.Draw();

            while (Score.score != 6)
            {
                //Show game info
                snake.SnakeSpeed();
                score.ShowScore();

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
                                StartStage_0();
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
                {
                    food.Draw();
                    snake.Move();
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.PushKey(key.Key);
                }
            }
            StartStage_2();
        }
    }
}
