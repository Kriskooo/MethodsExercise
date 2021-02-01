using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            Console.WriteLine($"{Factorial(firstNum, secondNum):F2}");
        }

        static double Factorial(double firstNum, double secondNum)
        {
            double factorialFirst = 1;
            for (double i = firstNum; i >= 1; i--)
            {
                factorialFirst *= i;
            }
            double factorialSecond = 1;
            for (double i = secondNum; i >= 1; i--)
            {
                factorialSecond *= i;
            }
            double division = factorialFirst / factorialSecond;
            return division;
        }
        // factorial na 7 e = 7*6*5*4*3*2*1
    }
}
