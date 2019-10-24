using System;
using static System.Console;

namespace DemoVariables3
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 4;
            bool isSixMore = 6 > value;

            WriteLine("When value is {0} isSixMore is {1}", value, isSixMore);
            
            value = 35;
            isSixMore = 6 > value;
            
            WriteLine("When value is {0} isSixMore is {1}", value, isSixMore);
        }
    }
}
