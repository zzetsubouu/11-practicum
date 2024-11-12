using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите x");
            int x = Convert.ToInt32(Console.ReadLine());
            double y = x < 5 ? F1(x) : F2(x);
            Console.WriteLine($"y={y}");
            Console.ReadKey();
        }
        public static double F1(int x)
        {
            return (4 * Math.Pow(x, 2) + 1) / (x - 5);
        }
        public static double F2(int x)
        {
            return 3 * Math.Pow(x, 2) - 2;
        }
    }
}
