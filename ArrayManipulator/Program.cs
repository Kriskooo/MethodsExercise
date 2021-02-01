using System;
using System.Collections.Generic;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> command = Console.ReadLine().Split(' ').ToList();

            while (command[0] != "end")
            {
                if (command[0] == "exchange")
                {
                    Exchange(numbers, command);
                }
                else if (command[0] == "max" && command[1] == "even" || command[0] == "max" && command[1] == "odd")
                {
                    MaxEvenOdd(numbers, command);
                }
                else if (command[0] == "min" && command[1] == "even" || command[0] == "min" && command[1] == "odd")
                {
                    MinEvenOdd(numbers, command);
                }
                command = Console.ReadLine().Split(' ').ToList();
            }
        }

        static void Exchange(List<int> numbers, List<string> command)
        {
            List<int> cloneNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                cloneNumbers.Add(numbers[i]);
            }

            int exchangeIndex = int.Parse(command[1].ToString());

            int exchange = numbers.Count - exchangeIndex;

            if (exchange > numbers.Count || exchange < 1)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            for (int i = 1; i <= exchange; i++)
            {
                int num = cloneNumbers[0];
                cloneNumbers.RemoveAt(0);
                cloneNumbers.Add(num);
            }

            Console.WriteLine($"[{string.Join(", ", cloneNumbers)}]");
        }

        static void MaxEvenOdd(List<int> numbers, List<string> command)
        {
            int maxEven = 0; int maxOdd = 0;

            if (command[1] == "even")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        if (numbers[i] >= maxEven)
                        {
                            maxEven = numbers[i];
                        }
                    }
                }
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (maxEven == numbers[i])
                    {
                        maxEven = i;
                    }
                }
                Console.WriteLine(maxEven);
                return;
            }
            else if (command[1] == "odd")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 1)
                    {
                        if (numbers[i] >= maxOdd)
                        {
                            maxOdd = numbers[i];
                        }
                    }
                }
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (maxOdd == numbers[i])
                    {
                        maxOdd = i;
                    }
                }
                Console.WriteLine(maxOdd);
                return;
            }
        }

        static void MinEvenOdd(List<int> numbers, List<string> command)
        {
            int minEven = int.MaxValue; int minOdd = int.MaxValue;

            if (command[1] == "even")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        if (numbers[i] <= minEven)
                        {
                            minEven = numbers[i];
                        }
                    }
                }
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (minEven == numbers[i])
                    {
                        minEven = i;
                    }
                }
                Console.WriteLine(minEven);
                return;
            }
            else if (command[1] == "odd")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 1)
                    {
                        if (numbers[i] <= minOdd)
                        {
                            minOdd = numbers[i];
                        }
                    }
                }
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (minOdd == numbers[i])
                    {
                        minOdd = i;
                    }
                }
                Console.WriteLine(minOdd);
                return;
            }
        }
    }
}

