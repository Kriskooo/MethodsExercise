using System;
using System.Collections.Generic;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Palindrome(text);
        }

        static void Palindrome(string text)
        {
            List<string> trueFalse = new List<string>(); 
            
            while (text != "END")
            {
                bool isTrue = true;
                for (int i = 0; i < text.Length / 2; i++)
                {
                    if (text[i] ==text[text.Length - 1 - i])
                    {
                    }
                    else
                    {
                        isTrue = false;
                    }
                }
                if (isTrue)
                {
                    trueFalse.Add("true");
                }
                else
                {
                    trueFalse.Add("false");
                }
                text = Console.ReadLine();                
            }
            foreach (var item in trueFalse)
            {
                Console.WriteLine(item);
            }
            
        }
    }

}
