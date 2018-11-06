using System;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120,30);

            HorizontalLine horizontalLineUp = new HorizontalLine(0, 118, 0, '+');
            Figure horizontalLineDown = new HorizontalLine(0, 118, 27, '+');
            Figure leftLine = new VerticalLine(0, 27, 0, '+');
            Figure rightLine = new VerticalLine(0, 27, 118, '+');

            horizontalLineUp.Draw();
            horizontalLineDown.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Point point = new Point(4, 5, '*');
            Snake snake = new Snake(point, 3, Direction.RIGHT);
            snake.Draw();
            snake.Move();

            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
        }
    }
}