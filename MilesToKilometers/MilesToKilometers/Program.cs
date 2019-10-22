using System;

namespace MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            // asking for user input
            Console.Write("Enter miles to convert to kilometers: ");
            // recording user input
            string response = Console.ReadLine();
            // tryparsing user input to a double, assuming it's valid
            if (!double.TryParse(response, out double miles))
            {
                // when the user input is not a valid number return
                Console.WriteLine("{0} is not a valid number.", response);
            } else
            {
                // calling the method milesToKilometers if it's a valid number
                Console.WriteLine("{0} miles is {1} kilometers", miles, milesToKilometers(miles));
            }
            // Calling Console.ReadLine() to keep the window open
            Console.ReadLine();
        }
        static double milesToKilometers(double miles)
        {
            // does the conversion using the formula km = mile * 1.6
            return miles * 1.6;
        }
    }
}
