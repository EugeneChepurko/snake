using System.Collections.Generic;

namespace Snake
{
    class Figure
    {
        protected List<Point> pointList;
        public virtual void Draw()
        {
            foreach (Point point in pointList)
            {
                point.Draw();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach (Point point in pointList)
            {
                if(figure.IsHit(point))
                    return true;
            }
            return false;
        }
        private bool IsHit(Point point)
        {
            foreach (Point p in pointList)
            {
                if(p.IsHit(point))
                    return true;
            }
            return false;
        }
    }
}
