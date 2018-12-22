using System;

namespace Snake
{
    class Score
    {
        public Score() { }

        public static int score = 0;
        public static int maxScore = 0;

        public void PrintScore()
        {
            Console.SetCursorPosition(45,10);
            Console.WriteLine("======================");
            Console.SetCursorPosition(48, 12);
            Console.WriteLine("G A M E  O V E R");
            Console.SetCursorPosition(45, 14);
            Console.WriteLine("======================");
            Console.SetCursorPosition(47, 15);
            Console.WriteLine("Play again? Y / N ?");
            Console.SetCursorPosition(49, 17);
            Console.WriteLine($"Your score = {score}");
            Console.SetCursorPosition(49, 18);
            Console.WriteLine($"Max score  = {maxScore}");
        }
    }
}
