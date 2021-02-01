using System;
using System.Collections.Generic;
using System.Linq;
namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbol = Console.ReadLine();
            string symbolTwo = Console.ReadLine();
            Console.WriteLine(Characters(symbol, symbolTwo));
        }

        static string Characters(string a, string b)
        {
            char first = a[0];
            char second = b[0];
            int min = Math.Min(first, second);
            int max = Math.Max(first, second);
            string text = "";
            for (int i = min + 1; i < max; i++)
            {
                text += (char)i;
                text += " ";
            }
            a = text;
            
            return a;
        }

        //{
        //    List<char> symbol = Console.ReadLine().Split(' ').Select(char.Parse).ToList();
        //    List<char> symbolTwo = Console.ReadLine().Split(' ').Select(char.Parse).ToList();
        //    Console.WriteLine(string.Join(" ", Characters(symbol, symbolTwo)));
        //}

        //static List<char> Characters(List<char> a, List<char> b)
        //{
        //    int first = a[0];
        //    int second = b[0];

        //    int min = Math.Min(first, second);
        //    int max = Math.Max(first, second);
        //    List<char> text = new List<char>();
        //    for (int i = min + 1; i < max; i++)
        //    {
        //        text.Add((char)i);
        //    }
        //    a.Clear();
        //    a = text;

        //    return a;
    }
}


