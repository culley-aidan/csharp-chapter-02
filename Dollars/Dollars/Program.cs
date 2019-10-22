using System;

namespace Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter dollars to convert: ");
            decimal.TryParse(Console.ReadLine(), out decimal dollars);
            
            Console.WriteLine(string.Format("{0} in twenties: {1} twenties and remainder of {2}", dollars.ToString("C"), decimal.ToInt32(dollars / 20), (dollars % 20).ToString("C")));
            Console.WriteLine(string.Format("{0} in tens: {1} tens and remainder of {2}", dollars.ToString("C"), decimal.ToInt32(dollars / 10), (dollars % 10).ToString("C")));
            Console.WriteLine(string.Format("{0} in fives: {1} fives and remainder of {2}", dollars.ToString("C"), decimal.ToInt32(dollars / 5), (dollars % 5).ToString("C")));
            Console.WriteLine(string.Format("{0} in ones: {1} ones and remainder of {2}", dollars.ToString("C"), decimal.ToInt32(dollars / 1), (dollars % 1).ToString("C")));
        }
    }
}
