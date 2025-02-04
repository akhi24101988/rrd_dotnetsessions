using System.Collections;
using HumanLib.Models;

namespace HumanCollectionsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var humans = new ArrayList();
            humans.Add(new Human("X", "Female", 50, 1.70, 60));
            humans.Add(new Human("Y", "Male", 40, 1.80, 70));
            humans.Add(new Human("Z", "Male", 30, 1.50, 80));

            foreach (object obj in humans)
            {
                Human human = (Human)obj;
                PrintCalculateBMI(human);
            }

        }

        private static void PrintCalculateBMI(Human human)
        {
            {
                try
                {
                    Console.WriteLine($"Name: {human.Name}");
                    Console.WriteLine($"Age: {human.Age}");
                    Console.WriteLine($"Height: {human.Height} m");
                    Console.WriteLine($"Weight: {human.Weight} kg");
                    Console.WriteLine($"Gender: {human.Gender}");
                    Console.WriteLine($"BMI: {human.CalculateBMI()}");
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: An unexpected error occurred while calculating BMI. {ex.Message}");
                }
            }
        }
    }
}
