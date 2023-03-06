using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = 17;

            var b = 4;

            var sum = a + b;

            var diff = a - b;

            var multi = a * b;

            var divi = a / b;

            var remainder = a % b;

            Console.WriteLine($"{a} plus {b} = {sum}.");

            Console.WriteLine($"{a} subtract {b} = {diff}.");

            Console.WriteLine($"{a} multiplied by {b} = {multi}.");

            Console.WriteLine($"{a} divided by {b} = {divi}.");

            Console.WriteLine($"The remainder of {a} divided by {b} is {a % b}");

            //Exercise 2 Area of a Circle
            Console.WriteLine("What is the radius of your circle?");

            var radius = double.Parse(Console.ReadLine());

            var area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("Area of Circle");
            
            Console.WriteLine($"The area of the circle with the radius of {radius} is {area}");

            // Though Expermiment
            var i = 3;
            var j = 4;
            var k = ++i * j++;

            Console.WriteLine(k); //16
        }
    }
}
