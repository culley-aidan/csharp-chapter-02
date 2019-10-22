using System;

namespace ProjectedRaises
{
    class Program
    {
        const decimal percentRaise = 0.04M;
        static void Main(string[] args)
        {
            Console.Write("Please enter the salary for employee 1: ");
            decimal.TryParse(Console.ReadLine(), out decimal employeeOne);
            employeeOne += employeeOne * percentRaise;
            Console.Write("Please enter the salary for employee 2: ");
            decimal.TryParse(Console.ReadLine(), out decimal employeeTwo);
            employeeTwo += employeeTwo * percentRaise;
            Console.Write("Please enter the salary for employee 3: ");
            decimal.TryParse(Console.ReadLine(), out decimal employeeThree);
            employeeThree += employeeThree * percentRaise;

            Console.WriteLine(String.Format("Next years salary for employee 1 is {0}, employee 2's salary is {1}, and employee 3's salary is {2}", employeeOne.ToString(), employeeTwo.ToString(), employeeThree.ToString()));
            Console.ReadLine();
        }
    }
}
