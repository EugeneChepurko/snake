using System.Collections.Generic;

namespace Snake.Stages
{
    class Stage_2
    {
        List<Figure> wallslist;

        public Stage_2(int mapWidth, int mapHeight)
        {
            wallslist = new List<Figure>();

            //Borders
            Figure horizontalLineUp = new HorizontalLine(0, mapWidth - 2, 0, '+');
            Figure horizontalLineDown = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
            Figure leftLine = new VerticalLine(0, mapHeight - 1, 0, '+');
            Figure rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');

            //Barriers
            Figure wall1 = new VerticalLine(0, 3, 30, '+');
            Figure wall2 = new VerticalLine(0, 8, 70, '+');
            Figure wall3 = new VerticalLine(mapHeight - 12, mapHeight - 5, 20, '+');
            Figure wall4 = new VerticalLine(mapHeight - 8, mapHeight - 1, 60, '+');
            Figure wall5 = new VerticalLine(mapHeight - 15, mapHeight - 8, 90, '+');


            wallslist.Add(horizontalLineUp);
            wallslist.Add(horizontalLineDown);
            wallslist.Add(leftLine);
            wallslist.Add(rightLine);

            wallslist.Add(wall1);
            wallslist.Add(wall2);
            wallslist.Add(wall3);
            wallslist.Add(wall4);
            wallslist.Add(wall5);
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
