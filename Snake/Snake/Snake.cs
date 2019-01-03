using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Snake
{
    class Snake : Figure
    {
        int HorizontalSpeed = 250;
        int VerticalSpeed = 300;
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

            if (_direction == Direction.UP || _direction == Direction.DOWN)
            {
                Thread.Sleep(VerticalSpeed);
            }
            else
            {
                Thread.Sleep(HorizontalSpeed);
            }
        }

        internal bool IsHitTail()
        {
            Point head = pointList.Last();
            for (int i = 0; i < pointList.Count - 2; i++)
            {
                if (head.IsHit(pointList[i]))
                    return true;
            }
            return false;
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
            Point tempFood = null;

            if (head.IsHit(food))
            {
                food.symbol = head.symbol;
                pointList.Add(food);
                Score.score += 1;

                for (int i = 0; i < pointList.Count; i++)
                {
                    if (!food.IsHit(pointList[i]))
                    {
                        if (head.IsHit(food))
                        {
                            if (!food.IsHit(GetNextPoint()))
                            {
                                head.Clear();
                                food.Draw();
                            }
                        }
                    }
                }
                if (HorizontalSpeed > 50)
                    HorizontalSpeed -= 10;
                if (VerticalSpeed > 100)
                    VerticalSpeed -= 10;
                tempFood = food;
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
        public void SnakeSpeed()
        {
            Console.SetCursorPosition(121, 1);
            Console.WriteLine($"Speed Vertical = {VerticalSpeed}");
            Console.SetCursorPosition(121, 2);
            Console.WriteLine($"Speed Horizontal = {HorizontalSpeed}");
            
        }
    }
}
