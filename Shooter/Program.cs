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
            int x = 10, y = 10; // начальные координаты

            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.Write("@");
            Console.SetCursorPosition(0, 20);
            Console.WriteLine($"Координаты: X={x}, Y={y}");

            do
            {
                key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.W:
                        y--;
                        Console.WriteLine("Вперед");
                        break;
                    case ConsoleKey.A:
                        x--;
                        Console.WriteLine("Влево");
                        break;
                    case ConsoleKey.D:
                        x++;
                        Console.WriteLine("Вправо");
                        break;
                    case ConsoleKey.S:
                        y++;
                        Console.WriteLine("Назад");
                        break;
                    case ConsoleKey.UpArrow:
                        y--;
                        Console.WriteLine("Вперед");
                        break;
                    case ConsoleKey.LeftArrow:
                        x--;
                        Console.WriteLine("Влево");
                        break;
                    case ConsoleKey.RightArrow:
                        x++;
                        Console.WriteLine("Вправо");
                        break;
                    case ConsoleKey.DownArrow:
                        y++;
                        Console.WriteLine("Назад");
                        break;
                    case ConsoleKey.Spacebar: Console.WriteLine("Прыжок"); break;
                    case ConsoleKey.Enter: Console.WriteLine("Огонь"); break;
                    case ConsoleKey.Escape: Console.WriteLine("Выход"); break;
                    default: Console.WriteLine("Error:\a:"); break;
                }

                // Обновляем позицию игрока
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.Write("@");

                // Показываем координаты
                Console.SetCursorPosition(0, 20);
                Console.WriteLine($"Координаты: X={x}, Y={y}");

            } while (key != ConsoleKey.Escape);
        }
    }
}