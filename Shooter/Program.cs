using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey key;
            int x = 10, y = 10;
            int consoleWidth = Console.WindowWidth;
            int consoleHeight = Console.WindowHeight - 2; 

            Console.Clear();
            Console.CursorVisible = false; 

            Console.SetCursorPosition(x, y);
            Console.Write("@");

            DisplayCoordinates(x, y);

            do
            {
                key = Console.ReadKey(true).Key;
                int oldX = x, oldY = y;

                switch (key)
                {
                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow:
                        if (y > 0) y--;
                        break;
                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        if (x > 0) x--;
                        break;
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        if (x < consoleWidth - 1) x++;
                        break;
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        if (y < consoleHeight - 1) y++;
                        break;
                }

                if (x != oldX || y != oldY)
                {
                    Console.SetCursorPosition(oldX, oldY);
                    Console.Write(" ");

                    Console.SetCursorPosition(x, y);
                    Console.Write("@");
                    DisplayCoordinates(x, y);
                }

            } while (key != ConsoleKey.Escape);
        }

        static void DisplayCoordinates(int x, int y)
        {
            int currentLeft = Console.CursorLeft;
            int currentTop = Console.CursorTop;

            Console.SetCursorPosition(0, Console.WindowHeight - 2);
            Console.Write(new string(' ', Console.WindowWidth)); 
            Console.SetCursorPosition(0, Console.WindowHeight - 2);
            Console.Write($"Координаты: X={x}, Y={y}");

            Console.SetCursorPosition(currentLeft, currentTop);
        }
    }
}