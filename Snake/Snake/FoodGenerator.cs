using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodGenerator
    {
        int mapWidth;
        int mapHeight;
        char food;
        Random random = new Random();

        public FoodGenerator(int mapWidth, int mapHeight, char food)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.food = food;
        }
        public Point CreateFood()
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, food);
        }
    }
}
