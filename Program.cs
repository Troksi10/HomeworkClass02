// See https://aka.ms/new-console-template for more information


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


Console.ReadLine();



