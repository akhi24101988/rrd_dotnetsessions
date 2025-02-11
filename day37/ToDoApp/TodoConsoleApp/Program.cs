namespace TodoConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Add Todo \n2. Display Todos \n3. Exit");
            int userNo = Convert.ToInt32(Console.ReadLine());
            if (userNo == 1)
            {
                Console.WriteLine("Enter your Todo item");
                string userTodo = (Console.ReadLine());
                Console.WriteLine(userTodo);
            }
            if (userNo == 2)
            { 
                DisplayTodo();
        }
            if (userNo == 3)
            {
                Exit();
            }
        }

        
    }
}
