using System.Collections.Generic;

namespace Snake.Stages
{
    class Stage_0
    {
        List<Figure> wallslist;

        public Stage_0(int mapWidth, int mapHeight)
        {
            wallslist = new List<Figure>();

            //Borders
            Figure horizontalLineUp = new HorizontalLine(0, mapWidth - 2, 0, '+');
            Figure horizontalLineDown = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
            Figure leftLine = new VerticalLine(0, mapHeight - 1, 0, '+');
            Figure rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');

            wallslist.Add(horizontalLineUp);
            wallslist.Add(horizontalLineDown);
            wallslist.Add(leftLine);
            wallslist.Add(rightLine);
        }
        internal bool IsHit(Figure figure)
        {
            foreach (Figure wall in wallslist)
            {
                if (wall.IsHit(figure))
                    return true;
            }
            return false;
        }
        public void Draw()
        {
            foreach (Figure wall in wallslist)
            {
                wall.Draw();
            }
        }
    }
}
