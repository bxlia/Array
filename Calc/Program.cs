using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите выражение: ");
            string input = Console.ReadLine();

            string[] parts = input.Split(' ');

            double num1 = double.Parse(parts[0]);
            string operation = parts[1];
            double num2 = double.Parse(parts[2]);
            double result = 0;

            if (operation == "+")
                result = num1 + num2;
            else if (operation == "-")
                result = num1 - num2;
            else if (operation == "*")
                result = num1 * num2;
            else if (operation == "/")
                result = num1 / num2;

            Console.WriteLine("Итог: " + result);
        }
    }
}