using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
            Random rand = new Random();
            int x = rand.Next(Console.WindowWidth);
            int y = rand.Next(Console.WindowHeight);
            Console.CursorVisible = false;
            ConsoleKey key;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.WriteLine('X');
                key = Console.ReadKey(true).KeyChar;

                switch(key)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W: y--; break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S: y++; break;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A: x--; break;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D: x++; break;
                }

                if (x == 0) x = 1;
                if (x == Console.WindowWidth) x = Console.WindowWidth - 1;
                if (y == 0) y = 1;
                if (y == Console.WindowHeight) y = Console.WindowHeight - 1;
            }
            while (key != ConsoleKey.Escape);
        }
    }
}
