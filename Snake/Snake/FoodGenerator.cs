using System;
using System.Collections.Generic;

namespace Snake
{
    class FoodGenerator : Figure
    {
        int mapWidth;
        int mapHeight;
        char food;
        Random random = new Random();
        Point prevPoint = null;

        public FoodGenerator(int mapWidth, int mapHeight, char food)
        {
            pointList = new List<Point>();
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.food = food;
        }
        public Point CreateFood(Figure figure)
        {
            while (true)
            {
                int x = random.Next(2, mapWidth - 2);
                int y = random.Next(2, mapHeight - 2);
                Console.SetCursorPosition(121, 3);
                Console.WriteLine($"Food X = {x}, Y = {y}");

                Point newPoint = new Point(x, y, food);
                if (!figure.IsHit(newPoint) && newPoint != prevPoint)
                {
                    prevPoint = newPoint;
                    return newPoint;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
