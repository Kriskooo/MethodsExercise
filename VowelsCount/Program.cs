using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string vowels = Console.ReadLine();

            Console.WriteLine(VowelsCount(vowels));
        }

        static string VowelsCount(string text)
        {

            string count = "";
            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];
                if (symbol == 'a' || symbol == 'A' || symbol == 'e' || symbol == 'E' || symbol == 'o' || symbol == 'O'
                    || symbol == 'u' || symbol == 'U' || symbol == 'i' || symbol == 'I')
                {
                    count += symbol;
                }
            }

            text = count;
            int a = text.Length;
            text = a.ToString();
            return text;

        }
    }
}
