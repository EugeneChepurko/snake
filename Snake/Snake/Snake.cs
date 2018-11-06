using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake
{
    class Snake : Figure
    {
        Direction _direction;
        public Snake(Point tail, int length, Direction direction)
        {
            _direction = direction;
            pointList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point point = new Point(tail);
                point.Move(i, direction);
                pointList.Add(point);
            }
        }
        public void Move()
        {
            Point tail = pointList.First();
            pointList.Remove(tail);
            Point head = GetNextPoint();
            pointList.Add(head);

            tail.Clear();
            head.Draw();
        }

        private Point GetNextPoint()
        {
            Point head = pointList.Last();
            Point nextHead = new Point(head);
            nextHead.Move(1, _direction);
            return nextHead;
        }
    }
}
