using System;

class PrintNameReverseUsingFunction
{
    static void Main(string[] userNames)
    {
        if (userNames.Length == 0)
        {
            Console.WriteLine("No arguments Passed, Pls pass the arguments");
            return;
        }
        PrintNameInStraight(userNames);
        PrintNameInReverse(userNames);
    }
    static void PrintNameInStraight(string[] userNames)//Straight order 
    {
        Console.WriteLine("Straight Order:");
        for (int i = 0; i < userNames.Length; i++)
        {
            Console.WriteLine("Hi Welcome: " + userNames[i]);
        }
    }
    static void PrintNameInReverse(string[] userNames)//Reverse order 
    {
        Console.WriteLine("Reverse Order:");
        for (int i = userNames.Length - 1; i >= 0; i--)
        {

            Console.WriteLine("Hi RRD Folks! " + userNames[i].ToUpper());
        }
    }

}