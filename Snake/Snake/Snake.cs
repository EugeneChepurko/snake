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
        internal void Move()
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
            head = new Point(head);
            head.Move(1, _direction);
            return head;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if(head.IsHit(food))
            {
                food.symbol = head.symbol;
                pointList.Add(food);
                head.Clear();
                food.Draw();
                return true;
            }
            return false;
        }

        public void PushKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                _direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                _direction = Direction.RIGHT;
            else if (key == ConsoleKey.UpArrow)
                _direction = Direction.UP;
            else if (key == ConsoleKey.DownArrow)
                _direction = Direction.DOWN;
        }
    }
}
