/*
    Solved by: Agustín Wamboldt M. // Killeon
    Date: 09/05/20
    Problem: Find e(Euler's Number) up to the Nth Digit (with bounds)
    Solution:
        1. Get e's value up to a certain point.
        2. Get user input to determine the result, up to a certain limit.
        3. Validate input data.
        4. Display result.
    
    Note: This solution aims at making an app to solve this problem, not calculating e.
*/

using System;

namespace FindEulerToTheNthDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get e's value.
            double euler = Math.E;
            
            Console.WriteLine("From the 1st to the 10th digit, up to which decimal do you want to calculate the Euler's Number?");
            bool validatedInput = false;
            int nth_digit;
            do
            {
                string input = Console.ReadLine();
                bool isNumeric = int.TryParse(input, out nth_digit);

                if (isNumeric && nth_digit >= 1 && nth_digit <= 10)
                {
                    validatedInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter an integer from 1 to 10.");
                }

            } while (!validatedInput);

            double res = Math.Round(euler, nth_digit);
            Console.WriteLine("Result: " + res);
        }
    }
}
