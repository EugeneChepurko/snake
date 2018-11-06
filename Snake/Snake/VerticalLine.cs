using System.Collections.Generic;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(){ }
        public VerticalLine(int yUp, int yDown, int x, char symbol)
        {
            pointList = new List<Point>();
            for (int i = yUp; i <= yDown; i++)
            {
                Point point = new Point(x, i, symbol);
                pointList.Add(point);
            }
        }
    }
}
