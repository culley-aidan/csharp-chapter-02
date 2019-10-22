using System;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] monthlyEggs = { 20, 18, 24, 21 };
            int iterations = 0, totalEggs = 0, eggDozen = 0, eggRemainder = 0;
            foreach(int egg in monthlyEggs)
            {
                iterations++;
                Console.WriteLine(string.Format("Chicken {0} layed {1} eggs this month", iterations, egg));
                totalEggs += egg;
            }
            eggDozen = totalEggs / 12;
            eggRemainder = totalEggs % 12;
            Console.WriteLine(string.Format("The total amount of eggs: {0} dozens + {1} eggs", eggDozen, eggRemainder));
            Console.ReadLine();
        }
    }
}
