using System;
class hello
{ 
static void Main(string[] userNames)
{
    //if (userNames.Length == 0)
    //{
    //    Console.WriteLine("No arguments passed!");
    //    //return;

    //}
    
    {
        foreach (string userName in userNames)
            Console.WriteLine("Hello" + userName + "!");
    }
}
