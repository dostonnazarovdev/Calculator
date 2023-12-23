// See https://aka.ms/new-console-template for more information
using System;

namespace Calculator
{
    class Program
    {
       static void Main()
       {
        Console.WriteLine("Enter values: ");
        Console.Write("Enter firstNumber: ");
        string firstNumber = Console.ReadLine();

        Console.Write("Enter secondNumber: ");
        string secondNumber = Console.ReadLine();

        Console.WriteLine("Converting values in progress.....");
        decimal firstUserValues = Convert.ToDecimal(firstNumber);
        decimal secondUserValues=Convert.ToDecimal(secondNumber);

        Console.WriteLine("Here are your results");
        Console.WriteLine($"{firstUserValues} + {secondUserValues} = {firstUserValues + secondUserValues}");
        Console.WriteLine($"{firstUserValues} - {secondUserValues} = {firstUserValues - secondUserValues}");
        Console.WriteLine($"{firstUserValues} * {secondUserValues} = {firstUserValues * secondUserValues}");
        Console.WriteLine($"{firstUserValues} / {secondUserValues} = {firstUserValues / secondUserValues}");
        Console.WriteLine($"{firstUserValues} % {secondUserValues} = {firstUserValues % secondUserValues}");
       }
    }
}
