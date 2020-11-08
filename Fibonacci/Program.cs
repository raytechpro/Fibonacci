using System;
using System.Numerics;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)        
        {
            int nthTerm = 100;

            BigInteger result = Fibonacci.CalculateFibonacci(nthTerm);
            Console.WriteLine($"F{nthTerm} is {result}");
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
