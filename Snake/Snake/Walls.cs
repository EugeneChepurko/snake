using System.Collections.Generic;

namespace Snake
{
    class Walls
    {
        List<Figure> wallsList;
        public Walls(int mapWidth, int mapHeight)
        {
            wallsList = new List<Figure>();

            Figure horizontalLineUp = new HorizontalLine(0, mapWidth - 2, 0, '+');
            Figure horizontalLineDown = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
            Figure leftLine = new VerticalLine(0, mapHeight - 1, 0, '+');
            Figure rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');

            wallsList.Add(horizontalLineUp);
            wallsList.Add(horizontalLineDown);
            wallsList.Add(leftLine);
            wallsList.Add(rightLine);
        }

        internal bool IsHit(Figure figure)
        {
            foreach (Figure wall in wallsList)
            {
                if(wall.IsHit(figure))
                    return true;
            }
            return false;
        }
        public void Draw()
        {
            foreach (Figure wall in wallsList)
            {
                wall.Draw();
            }
        }
    }
}
