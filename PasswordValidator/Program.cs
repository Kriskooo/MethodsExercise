using System;
using System.Linq;
namespace PasswordValidator
{

    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            PasswordValidator(password);
        }

        private static void PasswordValidator(string password)
        {
            if (password.Count(Char.IsDigit) >= 2 && password.Length >= 6 && password.Length <= 10 && password.All(Char.IsLetterOrDigit))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!(password.Length >= 6 && password.Length <= 10))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!password.All(Char.IsLetterOrDigit))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!(password.Count(Char.IsDigit) >= 2))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }
    }
}

    //static string PasswordValidator(string password)
    //{
    //    int counterOtherSymbols = 0;
    //    int counterSymbols = 0;
    //    int counterDigits = 0;
    //    string newMess = "";
    //    bool flagIsTrue = true;
    //    for (int i = 0; i < password.Length; i++)
    //    {
    //        char symbol = password[i];
    //        if (char.IsLetter(symbol))
    //        {
    //            counterSymbols++;
    //        }
    //        else if (char.IsDigit(symbol))
    //        {
    //            counterDigits++;
    //            counterSymbols++;
    //        }
    //        else
    //        {
    //            counterOtherSymbols++;
    //            counterSymbols++;
    //        }
    //    }
    //    if (counterOtherSymbols == 0)
    //    {
    //    }
    //    else
    //    {    
    //       newMess += "Password must consist only of letters and digits\n";
    //        flagIsTrue = false;
    //    }
    //    if (counterSymbols >= 6 && counterSymbols <= 10)
    //    {
    //    }
    //    else
    //    {
    //        newMess += "Password must be between 6 and 10 characters\n";
    //        flagIsTrue = false;
    //    }
    //    if (counterDigits >= 2)
    //    {
    //    }
    //    else
    //    {
    //        newMess += "Password must have at least 2 digits\n";
    //        flagIsTrue = false;
    //    }

    //    if (flagIsTrue)
    //    {
    //        newMess += "Password is valid";
    //    }
    //    password = newMess;
    //    return password;

    

