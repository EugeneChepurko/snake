using System;
using System.Collections.Generic;

namespace Snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char symbol)
        {
            pointList = new List<Point>();
            for (int i = xLeft; i <= xRight; i++)
            {
                Point point = new Point(i, y, symbol);
                pointList.Add(point);
            }
        }
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (Point point in pointList)
            {
                point.Draw();
            }
        }
    }
}
