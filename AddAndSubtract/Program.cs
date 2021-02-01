using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            Console.WriteLine(Sum(numberOne, numberTwo) - Subtract(numberThree));
        }

        static int Sum(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        
        static int Subtract(int c)
        {
            return c;
        }
    }
}
