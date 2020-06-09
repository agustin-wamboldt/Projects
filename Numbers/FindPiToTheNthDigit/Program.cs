/*
    Solved by: Agustín Wamboldt M. // Killeon
    Date: 09/05/20
    Problem: Find Pi up to the Nth Digit (with bounds)
    Solution:
        1. Get Pi's value up to a certain point.
        2. Get user input to determine the result, up to a certain limit.
        3. Validate input data.
        4. Display result.
    
    Note: header taken from Kurt Tricot.
*/

using System;

namespace FindPiToTheNthDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get Pi's value from the library.
            const double Pi = Math.PI;
            
            Console.WriteLine("From the 1st to the 10th integer, up to which Pi digit do you want me to calculate?");
            // Check that the user's input is valid. If it isn't, ask for another input.
            bool isAppropriate = false;
            int nth_digit;
            do
            {
                string user_input = Console.ReadLine();
                // Regex or TryParse, the latter does two things: checks if the string is a number and if it is, it casts it to int.
                bool isNumeric = int.TryParse(user_input, out nth_digit);

                if (isNumeric && nth_digit >= 1 && nth_digit <= 10) // Now we look for the Nth digit.
                {
                    isAppropriate = true;
                }
                else
                {
                    Console.WriteLine("You must choose an integer from 1 to 10.");
                }
            } while (!isAppropriate);
            
            double res = Math.Round(Pi, nth_digit);
            Console.WriteLine("Result: " + res);
        }
        // I couldn't find a way to use decimals type to calculate Pi through the BPP formula, since decimals can't be implicitly converted to 
        // double in the power, and even if I did truncate and convert it, it would imply precision loss/wrong result. 
        // Same thing with calculating it through doubles, the result would be wrong since doubles are floating point while decimals are fixed point.
    }
}