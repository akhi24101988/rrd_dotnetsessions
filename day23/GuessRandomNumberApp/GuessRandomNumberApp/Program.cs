using System;
class Program
{
    static void Main()
    {
        GuessNumber();

    }
    static void GuessNumber() 
    {
        Console.WriteLine("1. Play Game");
        Console.WriteLine("2. Exit Game");
        int entry = Convert.ToInt32(Console.ReadLine());
        if (entry == 1)
        {
            Console.Write("\nEnter the Player Name : "); 
            string playerName = Console.ReadLine();
            Console.WriteLine($"\nHey {playerName.ToUpper()}! The game generated a number from 1 to 50, you have three chances to guess it!\n");
            StartGame(playerName);
            return;
        }
        if (entry == 2)  
        {
            Console.WriteLine("\nYou have Exited the Game..Adios");
            return;
        }
       

    }
    static void StartGame(string playerName) 
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 50);
        int attempt = 3;
        
        for (int i = 1; i <= attempt; i++) //3 attempts
        {
            Console.Write($"\n{i}st Attempt : ");
            int guess = Convert.ToInt32(Console.ReadLine());
            if (IsCorrect(randomNumber, guess)) 
            {
                Console.WriteLine($"Hey {playerName.ToUpper()}! Thats correct, You Win");
                Restart(playerName);
                return;
            }
            if (!(IsCorrect(randomNumber, guess))) 
            {
                string result = (randomNumber < guess) ? "\nYour Guess is greater than Actual Number" : "\nYour Guess is Smaller than Actual Number";
                Console.WriteLine(result);
            }

        }
        Console.WriteLine("\nTry Again Later\n"); 
        Console.WriteLine($"The Correct Number is {randomNumber}");
        Restart(playerName);

        static void Restart(string playername) 
        {
            Console.Write("\nTo continue press 1 : ");
            int replyNo = Convert.ToInt32(Console.ReadLine());
            if (replyNo != 1)
            {
                Console.WriteLine("\nThe Game Ends! Thank you");
                return;
            }
            Console.WriteLine("\nThe Game has Restarted!\n");
            StartGame(playername);
        }

        static bool IsCorrect(int randomNumber, int guess) 
        {
            if (randomNumber == guess)
            {
                return true;
            }
            return false;
        }

    }
}