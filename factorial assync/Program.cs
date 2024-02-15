using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace factorial_async
{
    class Program
    {
        static public bool a = true;
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            FactorialAssync(n);
            Print(n);
            Console.ReadKey();
        }
        static void Factorial(BigInteger n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            a = false;
            Console.WriteLine(factorial);
        }
        static async void FactorialAssync(BigInteger n)
        {
            await Task.Run(() => Factorial(n));
        }
        static void Print(int n)
        {
            Thread.Sleep(1);
            if (!a)
                Console.WriteLine("надпись снизу. Попробуйте N побольше");
            else
                Console.WriteLine("надпись сверху. Попробуйте N поменьше");
        }       
    }
}
