using System.Collections.Generic;

namespace Snake.Stages
{
    class Stage_1
    {
        List<Figure> wallslist;
        public Stage_1(int mapWidth, int mapHeight)
        {
            wallslist = new List<Figure>();

            //Borders
            Figure horizontalLineUp = new HorizontalLine(0, mapWidth - 2, 0, '+');
            Figure horizontalLineDown = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
            Figure leftLine = new VerticalLine(0, mapHeight - 1, 0, '+');
            Figure rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');

            //Barriers
            Figure wall1 = new VerticalLine(0, 6, 50, '+');
            Figure wall2 = new VerticalLine(mapHeight - 8, mapHeight - 2, 90, '+');
            Figure wall3 = new VerticalLine(mapHeight - 10, mapHeight - 2, 30, '+');

            wallslist.Add(horizontalLineUp);
            wallslist.Add(horizontalLineDown);
            wallslist.Add(leftLine);
            wallslist.Add(rightLine);

            wallslist.Add(wall1);
            wallslist.Add(wall2);
            wallslist.Add(wall3);
        }
        internal bool IsHit(Figure figure)
        {
            foreach (Figure wall in wallslist)
            {
                if(wall.IsHit(figure))
                {
                    return true;
                }
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
