
namespace AbstractionCircleApp.Models
{
    class CircleShape
    {
        static void Main()
        {
            Circle circleSmall = new Circle();
            circleSmall.radius = 10;
            circleSmall.calculateArea();
            Console.WriteLine("The radius is " + circleSmall.radius + " Area of circle1: " + circleSmall.calculateArea());

            Circle circleBig = new Circle();
            circleBig.radius = 100;
            circleBig.calculateArea();
            Console.WriteLine("The radius is " + circleBig.radius + " Area of circle1: " + circleBig.calculateArea());

        }
    }

}
