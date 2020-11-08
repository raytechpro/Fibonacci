using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Fibonacci
{
    /// <summary>
    /// Fibonacci methods 
    /// </summary>
    public static class Fibonacci
    {
        /// <summary>
        /// Calculates Fibonacci nth Term 
        /// Fₙ = Fₙ₋₂ + Fₙ₋₁
        /// </summary>
        /// <returns>
        /// The Fibonacci value 
        /// </returns>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when nthTerm parameter is less than 0
        /// </exception>
        /// <param name="nthTerm">nth Term to find</param>
        public static BigInteger CalculateFibonacci(int nthTerm)
        {
            if (nthTerm < 0)
                throw new ArgumentOutOfRangeException("nth Term must be 0 or greater.");

            BigInteger num1 = 0;
            BigInteger num2 = 1;
            BigInteger sum = 0;
            for (int i = 2; i <= nthTerm; i++)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
            }
            return sum;
        }
    }
}
