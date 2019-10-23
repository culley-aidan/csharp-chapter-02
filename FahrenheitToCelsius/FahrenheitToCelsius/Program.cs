using System;

namespace FahrenheitToCelsius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a fahrenheit value: ");
            bool validValue = double.TryParse(Console.ReadLine(), out double fahrenheit);
            while (!validValue)
            {
                Console.Write("Enter a valid number: ");
                validValue = double.TryParse(Console.ReadLine(), out fahrenheit);
            }
            Console.WriteLine("{0}F is {1}C", fahrenheit, ftc(fahrenheit));
        }
        static double ftc(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
