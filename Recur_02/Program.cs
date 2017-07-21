using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Вычиление двойного факториала n * (n-2) * (n-4) ... * 2(1).
 */

namespace Recur_02
{
    class Program
    {
        static int Factorial2(int n, ref int result)
        {
            if (n != 1 && n != 0)
            {
                result *= n;
                n=n-2;
                Factorial2(n, ref result);
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            Factorial2(n, ref result);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
