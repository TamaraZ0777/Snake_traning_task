using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProjectConsoleApp
{
    public class Point
    {
        int _left;
        int _top;
        char _symbol;

        public Point(int left, int top, char symbol)
        {
            _left = left;
            _top = top;
            _symbol = symbol;
        }

        public void DrawPoint()
        {
            Console.SetCursorPosition(_left, _top);
            Console.Write(_symbol);
        }
    }
}
