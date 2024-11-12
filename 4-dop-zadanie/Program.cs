using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_dop_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //вывести четные двузначные числа в столбик через дополнительный метод
            Console.Write("начальное значение:");
            int startValue = int.Parse(Console.ReadLine());
            Console.Write("конечное значение:");
            int endValue = int.Parse(Console.ReadLine());
            Console.Write("введите шаг:");
            int step = int.Parse(Console.ReadLine());
            Function123(startValue, endValue, step);
            Console.ReadKey();
        }
        public static void Function123(int start, int end, int step)
        {
            int count = 0;
            for (int startV = start; startV < end; startV += step)
            {
                if (startV % 2 == 0)
                {
                    Console.WriteLine(startV);
                    count++;
                }
            }
            Console.WriteLine($"колво четных чисел: {count}");

        }
    }
}
