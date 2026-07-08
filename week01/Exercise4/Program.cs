using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Main list creation
        List<int> numbers = new List<int>();

        // Loop logic for add numbers to the main list
        int userNumber = -1;
        while (userNumber != 0)
        {
            // Ask user for a number
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            //  Not adding 0 to the list logic
            if (userNumber != 0)
            {
                // Add user number to the list
                numbers.Add(userNumber);
            }
        }
        
        // Avoid program failing if user types 0 as first number
        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
        }
        else
        {
            // Sum logic
            int sum = 0;
            foreach (int number in numbers)
            {
                sum = number + sum;
            }

            // Average logic
            int listElements = numbers.Count;
            double average = (double)sum / listElements;

            // Largest number logic
            int largestNumber = numbers[0];
            foreach (int number in numbers)
            {
                if (largestNumber < number)
                {
                    largestNumber = number;
                }
            }

            // Smallest positive number logic
            int smallestPositiveNumber = 0;
            bool foundPositive = false;

            foreach (int number in numbers)
            {
                if (number > 0)
                {
                    if (!foundPositive || number < smallestPositiveNumber)
                    {
                        smallestPositiveNumber = number;
                        foundPositive = true;
                    }
                }
            }

            // Sort list 
            numbers.Sort();

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {largestNumber}");

            // Print smallest positive number if found
            if (foundPositive)
            {
                Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");
            }
            else
            {
                Console.WriteLine("There is no positive number.");
            }

            // Print sorted list
            Console.WriteLine("The sorted list is:");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}