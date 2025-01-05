using System;
class User
{
      static void Main(string[] userNames)
    {
        if (userNames.Length == 0)
        {
            Console.WriteLine("No arguments passed!");
            return;

        }
        foreach (string userName in userNames)
            Console.WriteLine("Hello " + userName + "!");
        Console.WriteLine("");
        {
            for (int index = userNames.Length-1; index >= 0; index--)
                //userNames[index] = userNames[index].ToUpper();
            Console.WriteLine(userNames[index].ToUpper());

        }
    }

}