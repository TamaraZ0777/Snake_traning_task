using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProjectConsoleApp.Factory
{
    public static class FoodFactory
    {
        private static Random _random = new Random();
        public static Point GetRandomFood(int spaceWidth, int SpaceHeight, char symbol)
        {
            spaceWidth = _random.Next(2, spaceWidth - 2);
            SpaceHeight = _random.Next(2, SpaceHeight - 2);

            return new Point(spaceWidth, SpaceHeight, symbol);
        }
    }
}
