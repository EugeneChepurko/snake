using System;

namespace Snake
{
    class Point
    {
        int x;
        int y;
        public char symbol;

        public Point(int x, int y, char symbol)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
        }
        public Point(Point point)
        {
            x = point.x;
            y = point.y;
            symbol = point.symbol;
        }
        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
        public void Clear()
        {
            symbol = ' ';
            Draw();
        }

        internal bool IsHit(Point point)
        {
            return point.x == this.x && point.y == this.y;
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + symbol;
        }
    }
}