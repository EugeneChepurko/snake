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
    }
}
