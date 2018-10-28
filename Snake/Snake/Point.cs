using System;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char symbol;

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
}
