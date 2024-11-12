using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = InputX("x");
            int y = InputX("y");
            Console.WriteLine($"сумма значений: {Sum(x, y)}");
            Console.WriteLine($"разность значений: {Diff(x, y)}");
            Console.WriteLine($"произведение значений: {Multipl(x, y)}");
            Console.WriteLine($"частное значений: {Div(x, y):N3}");

            Console.ReadKey();
        }
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        public static int Diff(int x, int y)
        {
            return x - y;
        }
        public static int Multipl(int x, int y)
        {
            return x * y;
        }
        public static double Div(int x, int y)
        {
            return (double)x / y;
        }
        public static int InputX(string x)
        {
            Console.Write($"введите первое значение:");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static int InputY(string y)
        {
            Console.Write($"введите первое значение: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
