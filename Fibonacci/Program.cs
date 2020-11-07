using System;
using System.Numerics;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)        
        {
            int nthTerm = 4;

            BigInteger result = Fibonacci.CalculateFibonacci(nthTerm);
            Console.WriteLine($"F{nthTerm} is {result}");
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }

    public static class Fibonacci
    {
        public static BigInteger CalculateFibonacci(int nthTerm)
        {
            if (nthTerm < 0)
                throw new ArgumentOutOfRangeException("nth Term must be 0 or greater.");

            BigInteger num1 = 0;
            BigInteger num2 = 1;
            BigInteger sum = 0;
            for (int i=2; i <= nthTerm; i++)
            {  
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
            }
            return sum;
        }
    }
}
