using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            Console.ReadKey();
        }
    }
}