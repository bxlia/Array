//#define NUMERIC_IYPES
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static readonly string delimiter = "\n---------------------------------------\n";
        static void Main(string[] args)
        {
#if NUMERIC_IYPES
            Console.WriteLine("DataTypes");
            Console.WriteLine("ЦЕЛОЧИСЛЕННЫЕ ТИПЫ");

            Console.WriteLine("byte");
            Console.Write($"byte занимает {sizeof(byte)} Байт памяти, и принимает значения в диапазоне");
            Console.WriteLine($" Беззнаковый byte от {byte.MinValue} до {byte.MaxValue}, Класс-обвертка - {typeof(byte)}");
            Console.WriteLine($"    Знаковый byte от {sbyte.MinValue} до {sbyte.MaxValue}, Класс-обвертка - {typeof(sbyte)}");
            Console.WriteLine(delimiter);

            Console.WriteLine("short");
            Console.Write($"short занимает {sizeof(short)} Байт памяти, и принимает значения в диапазоне");
            Console.WriteLine($" Беззнаковый short от {short.MinValue} до {short.MaxValue}, Класс-обвертка - {typeof(short)}");
            Console.WriteLine($"    Знаковый short от {ushort.MinValue} до {ushort.MaxValue}, Класс-обвертка - {typeof(ushort)}");
            Console.WriteLine(delimiter);

            Console.WriteLine("Integer - Целое число");
            Console.Write($"int занимает {sizeof(int)} Байт памяти, и принимает значения в диапазоне");
            Console.WriteLine($" Беззнаковый int от {int.MinValue} до {int.MaxValue},\t\t\t Класс-обвертка - {typeof(int)}");
            Console.WriteLine($"    Знаковый int от {uint.MinValue} до {uint.MaxValue}, Класс-обвертка - {typeof(uint)}");
            Console.WriteLine(delimiter);

            Console.WriteLine("long");
            Console.Write($"long занимает {sizeof(long)} Байт памяти, и принимает значения в диапазоне");
            Console.WriteLine($" Беззнаковый long от {long.MinValue} до {long.MaxValue},\t\t Класс-обвертка - {typeof(long)}");
            Console.WriteLine($"    Знаковый long от {ulong.MinValue} до {ulong.MaxValue}, Класс-обвертка - {typeof(ulong)}");
            Console.WriteLine(delimiter);

            Console.WriteLine("float");
            Console.Write($"float занимает {sizeof(float)} Байт памяти, и принимает значения в диапазоне");
            Console.WriteLine($"Знаковый float от {float.MinValue} до {float.MaxValue}, Класс-обвертка - {typeof(float)}");
            Console.WriteLine(delimiter);

            Console.WriteLine("double");
            Console.Write($"double занимает {sizeof(double)} Байт памяти, и принимает значения в диапазоне");
            Console.WriteLine($"Знаковый double от {double.MinValue} до {double.MaxValue}, Класс-обвертка - {typeof(double)}");
            Console.WriteLine(delimiter);

            Console.WriteLine("decimal");
            Console.Write($"decimal занимает {sizeof(decimal)} Байт памяти, и принимает значения в диапазоне");
            Console.WriteLine($"Знаковый decimal от {decimal.MinValue} до {decimal.MaxValue}, Класс-обвертка - {typeof(decimal)}");
            Console.WriteLine(delimiter);
#endif
            int a = 2;
            byte b = (byte)a;
        }
    }
}
