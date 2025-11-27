using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntraductionToDOTNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Intro to .NET";
            Console.WriteLine("Hello World!");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(35, 5);
            Console.Write("Привет Мир!\n");
            Console.ResetColor();
            Console.Beep(200, 3000);

            Console.WriteLine("Введите ваше имя: ");
            string first_name = Console.ReadLine();

            Console.WriteLine("Введите вашу фамилию: ");
            string last_name = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(first_name + " " + last_name + " " + age); //Конкатенация строк 
            Console.WriteLine($"{first_name} {last_name} {age}"); //Интероляция строк
        }
    }
}
