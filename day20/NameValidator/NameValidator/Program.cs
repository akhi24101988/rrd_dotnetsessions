using System;
class Program
{
    static void Main()
    {

        NameValidator();
    }
    static void NameValidator()
    {

        while (true)
        {
            Console.WriteLine("Enter your Name");
            string userName = Console.ReadLine();
            if (CheckUserName(userName))
            {
                Console.WriteLine($"Hey {userName} Welcome Back!");
                break;
            }
            Console.WriteLine("Enter your name without special characters!");

        }
    }
    static bool CheckUserName(string userName)
    {

        foreach (char c in userName)
        {
            if ((c == 32))
                return false;
            if ((c < 65 || c > 90) && (c < 97 || c > 122))
                return false;
        }
        return true;
    }
}