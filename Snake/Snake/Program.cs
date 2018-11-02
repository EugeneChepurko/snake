using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            Point p2 = new Point(2, 4, '*');         
            Point p3 = new Point(3, 5, '*');         
            Point p4 = new Point(4, 6, '*');         

            List<Point> numList = new List<Point>();
            numList.Add(p1);
            numList.Add(p2);
            numList.Add(p3);
            numList.Add(p4);
            
            foreach (Point x in numList)
            {
                x.Draw();
            }
        }
    }
}