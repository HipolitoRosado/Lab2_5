using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            int number1, number2, number3;
            Console.WriteLine("Enter first number");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number");
            number3 = Convert.ToInt32(Console.ReadLine());
            int result = number1 * number2 * number3;
            Console.WriteLine("The answer for the multiplication of your 3 numbers is " +result);
          








        }
    }
}
