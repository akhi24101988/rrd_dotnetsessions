
namespace DelegateMathOperator
{
    internal class Program
    {
        delegate double MathOperator(double a, double b);
        static void Main(string[] args)
        {
           
            CaseStudy1();
        }

        private static void CaseStudy1()
        {
            MathOperator x;
            x = Addition;
            Console.WriteLine("Addition Result is :" + Addition(10, 2));
            x += Subtraction;
            Console.WriteLine("Subtraction Result is :" + Subtraction(10, 2));
            x += Multiplication;
            Console.WriteLine("Multiplication Result is :" + Multiplication(10, 2));
            x += MOdulus;
            Console.WriteLine("MOdulus Result is :" + MOdulus(10, 2));
            //x(10, 2);
        }

        static double Addition(double x, double y)
        {
            return x + y;
        }
        static double Subtraction(double x, double y)
        {
            return x - y;
        }
        static double Multiplication(double x, double y)
        {
            return x * y;
        }
        static double MOdulus(double x, double y)
        {
            return x % y;
        }
    }
}
