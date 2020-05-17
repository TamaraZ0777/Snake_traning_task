using SnakeProjectConsoleApp.Factory;
using SnakeProjectConsoleApp.Helpers;
using SnakeProjectConsoleApp.Installers;
using SnakeProjectConsoleApp.Lines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProjectConsoleApp
{
    class Program
    {
        static void Main(string[] args)
                
        {
            LineInstaller line = new LineInstaller();
            line.DrawShapes();

            Point point = FoodFactory.GetRandomFood(119, 20, '+');
            Console.ForegroundColor = ColorHelper.GetRandomColor(new Random().Next(1, 5));
            point.DrawPoint();
            Console.ResetColor();


        }
    }
}
