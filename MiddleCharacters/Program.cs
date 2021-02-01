using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(MiddleChar(text));
        }

        static string MiddleChar(string text)
        {
            string word = "";

            if (text.Length % 2 == 1)
            {
                word += text[(text.Length - 1) / 2];
            }
            else if (text.Length % 2 == 0)
            {
                for (int i = text.Length / 2 - 1; i <= text.Length / 2; i++)
                {
                    word += text[i];
                }
            }
            return word;
        }
    }
}
