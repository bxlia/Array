
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        const string delimeter = "\n------------------------------";
        /*static void Main(string[] args)
        {
        #if ARRAYS1
            int[] arr = { 3, 5, 8, 13, 21 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();

            int sum1 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum1 += arr[i];
            }
            double average1 = (double)sum1 / arr.Length;
            Console.WriteLine($"Сумма: {sum1}");
            Console.WriteLine($"Среднее арифметическое: {average1:F2}");

            int min1 = arr[0];
            int max1 = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min1) min1 = arr[i];
                if (arr[i] > max1) max1 = arr[i];
            }
            Console.WriteLine($"Минимальный элемент: {min1}");
            Console.WriteLine($"Максимальный элемент: {max1}");

            Console.ReadKey();*/

        static void Main()
        {
            Random random = new Random();

            Console.Write("Введите количество строк: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов: ");
            int columns = int.Parse(Console.ReadLine());

            int[,] array = new int[rows, columns];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1, 101); 
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }

            Console.WriteLine($"\nСумма элементов: {sum}");
            Console.WriteLine($"\nСреднее-арифметическое элементов: {(double)sum/array.Length}");
            Console.WriteLine(delimeter);
            Console.WriteLine($"\nСумма элементов: {array.Cast<int>().Sum()}");
            Console.WriteLine($"\nМинимальное значение: {array.Cast<int>().Min()}");
            Console.WriteLine($"\nМаксимальное значение: {array.Cast<int>().Max()}");

        }
    }
}

