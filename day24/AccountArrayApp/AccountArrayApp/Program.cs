using System;
using System.Reflection.PortableExecutable;
using AccountApp.Models;

class Program
{
    static void Main(string[] args)
    {
        Account Akhilesh = new Account(1001, "Akhilesh", 1000);
        Account Sachin = new Account(1002, "Sachin", 1000);
        Account Venkat = new Account(1003, "Venkatesh", 10000);
        Account[] allAccounts = { Akhilesh, Sachin, Venkat };
        PrintDetails(allAccounts);
        PrintLongestName(allAccounts);
        PrintRichestAccountHolder(allAccounts);
        //    Akhilesh.Deposit(500);
        //    Sachin.Withdraw(500);
        //    AccountTransfer(Akhilesh,Sachin,500);
        //}
    }

    private static void PrintDetails(Account[] allAccounts)
    {
        foreach (Account account in allAccounts)
        {
            Console.WriteLine();
        }

        //Console.WriteLine($"details are {allAccounts[0].Name} {Sachin.AccountNumber} {Venkat.AccountNumber}");
    }
    private static void PrintLongestName(Account[] allAccounts)

    {
        int maxLength = 8;
        for (int i = 0; i < allAccounts.Length; i++)
        {
            if (allAccounts[i].Name.Length >= maxLength)
            {
                Console.WriteLine($"Longest name is {allAccounts[i].Name}");
            }
        }
    }
        private static void PrintRichestAccountHolder(Account[] allAccounts)

    {
        double HighestBalance = allAccounts[0].Balance;
        for (int i = 1; i < allAccounts.Length; i++)
        {
            if (allAccounts[i].Balance > HighestBalance)
            {
                Console.WriteLine($"Richest Accountholder is {allAccounts[i].Name} !");
            }
        }
    }

    //private static void AccountTransfer(Account[]allAccounts)
    //{ }
   
}

