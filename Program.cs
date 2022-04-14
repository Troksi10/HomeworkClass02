using System;

namespace Real_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create new console application “RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done ( +, - , * , / ). Then it returns the result.
            //Test Data:
            //Enter the First number: 10
            //Enter the Second number: 15
            //Enter the Operation: +
            //Expected Output:
            //The result is: 25

            Console.WriteLine("Enter the First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operation:");
            string operation = Console.ReadLine();

            if (operation == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else
            {
                Console.WriteLine("Invalid operation");
            }
            
            Console.ReadLine();
        }
    }
}
