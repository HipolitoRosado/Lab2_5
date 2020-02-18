using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int number1, number2;
            Console.WriteLine("Enter 1st number");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            number2 = Convert.ToInt32(Console.ReadLine());

            int result1 = number1 + number2;
            Console.WriteLine("Addition is:");
            Console.WriteLine(result1);

            int result2 = number1 - number2;
            Console.WriteLine("Subtraction is:");
            Console.WriteLine(result2);

            int result3 = number1 * number2;
            Console.WriteLine("Multiplication  is:");
            Console.WriteLine(result3);

            double result4 = (double)number1 / (double)number2;
            Console.WriteLine("Division result is:");
            Console.WriteLine(result4);
            

        }

    }
}
