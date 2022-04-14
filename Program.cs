// See https://aka.ms/new-console-template for more information

Console.WriteLine("======= Real Calculator ======== ");

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

Console.WriteLine("========= AverageNumber=========== ");

//Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.

//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the third number: 20
//Enter the four number: 30
//Expected Output:
//The average of 10, 15, 20 and 30 is: 18

Console.WriteLine("Enter the First Number");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Second Number");
int secondNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Third Number");
int thirdNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Fourth Number");
int fourthNum = Convert.ToInt32(Console.ReadLine());

int AverageNumber = (firstNum + secondNum + thirdNum + fourthNum) / 4;
Console.WriteLine($"The average of 10,15,20 and 30 is : {AverageNumber}");

Console.WriteLine("============Swap numbers ==================");

// Create new console application “SwapNumbers”.
//Input 2 numbers from the console and then swap the values of the variables so that the first variable has the second value and the second variable the first value.
//Please find example below:
// *Test Data:
// *Input the First Number: 5
// * Input the Second Number: 8
// * Expected Output:
//  *After Swapping:
//*First Number: 8
//* Second Number: 5


int firstSwapNum = 5;
Console.WriteLine("Input the First Number:" + firstSwapNum);
int secondSwapNum = 8;
Console.WriteLine("Input the Second Number:" + secondSwapNum);
int swap;

swap = firstSwapNum;
firstSwapNum = secondSwapNum;
secondSwapNum = swap;

Console.WriteLine("=================After swapping numbers================");
Console.WriteLine("First Number is :" + firstSwapNum);
Console.WriteLine("Second Number is :" + secondSwapNum);

Console.ReadLine();
