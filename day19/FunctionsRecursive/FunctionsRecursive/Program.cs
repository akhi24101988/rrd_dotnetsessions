using System;
class Recursive
{
    static void Main()
    {
        PrintName("Akhi", 10);
    }

    static void PrintName(string name, int i)
    {
        if (i >0)
        {
            Console.WriteLine($"Hello " + (name));
            PrintName(name, i - 1);
        }
    }
    } 