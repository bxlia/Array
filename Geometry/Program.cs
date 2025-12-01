using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер фигуры: ");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine("\n1. Прямоугольник:");
            DrawRectangle(size);

            Console.WriteLine("\n2. Растущий треугольник:");
            DrawGrowingTriangle(size);

            Console.WriteLine("\n3. Убывающий треугольник:");
            DrawDecreasingTriangle(size);

            Console.WriteLine("\n4. Треугольник вниз:");
            DrawIndentedTriangle(size);

            Console.WriteLine("\n5. Зеркальный наверх:");
            DrawMirrorTriangle(size);

            Console.WriteLine("\n6. Ромб:");
            DrawRhombus(size);
        }

        static void DrawRectangle(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("* ");
                    Thread.Sleep(20);
                }
                Console.WriteLine();
                Thread.Sleep(50);
            }
        }

        static void DrawGrowingTriangle(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                    Thread.Sleep(20);
                }
                Console.WriteLine();
                Thread.Sleep(50);
            }
        }

        static void DrawDecreasingTriangle(int size)
        {
            for (int i = size; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                    Thread.Sleep(20);
                }
                Console.WriteLine();
                Thread.Sleep(50);
            }
        }

        static void DrawIndentedTriangle(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < i * 2; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < size - i; j++)
                {
                    Console.Write("* ");
                    Thread.Sleep(20);
                }
                Console.WriteLine();
                Thread.Sleep(50);
            }
        }

        static void DrawMirrorTriangle(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 0; j < (size - i) * 2; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                    Thread.Sleep(20);
                }
                Console.WriteLine();
                Thread.Sleep(50);
            }
        }

        static void DrawRhombus(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 0; j < size - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("*");
                    Thread.Sleep(10);
                }
                Console.WriteLine();
                Thread.Sleep(50);
            }

            for (int i = size - 1; i >= 1; i--)
            {
                for (int j = 0; j < size - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("*");
                    Thread.Sleep(10);
                }
                Console.WriteLine();
                Thread.Sleep(50);
            }
        }
    }
}