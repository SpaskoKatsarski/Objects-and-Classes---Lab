using System;
using System.Numerics;

namespace T02._Big_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int factorialNumber = int.Parse(Console.ReadLine());
            
            BigInteger multiplication = 1;

            for (int i = factorialNumber; i > 1; i--)
            {
                multiplication *= i;
            }

            Console.WriteLine(multiplication);
        }
    }
}
