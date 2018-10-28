using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 3;
            char symbol = '*';
            Draw(x1, y1, symbol);

            int x2 = 2;
            int y2 = 4;
            Draw(x2, y2, symbol);
            Console.WriteLine("dwdw" + x1.GetType());
        }
        static void Draw(int x, int y, char symb)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }
    }
}