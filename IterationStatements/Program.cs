using System;
using System.Net.Http.Headers;

namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()

        public static void PrintNumbers()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()

        public static void CountByThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.

        public static void AreNumbersEqual(int num1, int num2)
        {
            var message = (num1 == num2) ? "The numbers are equal." : "The numbers are not equal.";
            Console.WriteLine(message);
        }

        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.

        public static void IsEvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is an even number");
            }
            else
            {
                Console.WriteLine($"{number} is an odd number");
            }

        }


        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.

        public static void IsPosOrNeg(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"{number} is postive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} is negative.");
            }
            else if (number == 0)
            {
                Console.WriteLine($"{number} is neither postive or negative");
            }
        }

        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        public static void CanVote()
        {
            Console.WriteLine("Please enter your age:");
            var canParse = int.TryParse(Console.ReadLine(), out int userAge);

            while (canParse == false)
            {
                Console.WriteLine("Please enter a valid age");
                canParse = int.TryParse(Console.ReadLine(), out _);
            }

            if (userAge >= 18)
            {
                Console.WriteLine("Your old enough to vote");
            }
            else
            {
                Console.WriteLine("Your note old enough to vote");
            }

        }

        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.

        public static void IsInRange()
        {
            Console.WriteLine("Please enter a fith number");
            var canParse = int.TryParse(Console.ReadLine(), out int num5);

            while (canParse == false)
            {
                Console.WriteLine("Please enter a valid number");
                canParse = int.TryParse(Console.ReadLine(), out _);
            }

            if (num5 <= 10 && num5 >= -10)
            {
                Console.WriteLine($"{num5} is in the 10 range");
            }
            else
            {
                Console.WriteLine($"{num5} is not in the 10 range");
            }
        }

        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"

        public static void DisplayMultiplicationTable(int num6)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {num6} = {i * num6}");
            }
        }

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            // Run 1
            Console.WriteLine("Prints all numbers from 1000 down to -1000:");
            PrintNumbers();

            // Run 2
            Console.WriteLine("Count up by three:");
            CountByThree();

            // Run 3
            Console.WriteLine("Enter a number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a secound number:");
            int num2 = int.Parse(Console.ReadLine());

            AreNumbersEqual(num1, num2);

            //Run 4
            Console.WriteLine("Enter a third number:");
            int num3 = int.Parse(Console.ReadLine());
            IsEvenOrOdd(num3);

            //Run 5
            Console.WriteLine("Enter a forth number:");
            int num4 = int.Parse(Console.ReadLine());
            IsPosOrNeg(num4);

            //Run 6
            CanVote();

            //Run Heatin' Up Section 1
            IsInRange();

            //Run Heatin' Up Section 2
            Console.WriteLine("Enter a sixth number:");
            int num6 = int.Parse(Console.ReadLine());
            DisplayMultiplicationTable(num6);

        }
    }
}
