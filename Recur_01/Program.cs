using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recur_01
{
    class Program
    {
        static int Factorial(int n, ref int result)
        {
            result *= n;
            n--;
            if (n>0)
            {
                Factorial(n,ref result);
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            Factorial(n,ref result);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
