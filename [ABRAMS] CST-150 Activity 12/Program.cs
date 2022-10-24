// Jared L. Abrams// CST-150// October 23, 2022// This is my own work

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ABRAMS__CST_150_Activity_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Two int for tracking total 't' or 'e' count and char placement in while loop.
            int letterCount = 0, charPlace = 0;

            // Read input.txt and assign to input string variable.
            string input = System.IO.File.ReadAllText("Input.txt");

            // Loop through string.
            while (charPlace <= input.Length - 1)
            {
                // If the character in the loop is a character used to indicate the end of a word & the character before that is a 't' or 'e'.
                if ((
                    input[charPlace] == '.' ||
                    input[charPlace] == ' ' ||
                    input[charPlace] == '?' ||
                    input[charPlace] == '!' ||
                    input[charPlace] == ',' ||
                    input[charPlace] == '\t' || // tab
                    input[charPlace] == '\n') && // new line
                    (input[charPlace - 1] == 't' || input[charPlace - 1] == 'e'))
                {
                    letterCount++; // Increment if 't' or 'e' at the end of a word.
                }
                charPlace++; // Increment character placement in loop.
            }

            // Print results.
            Console.WriteLine("There are " + letterCount + " words ending in t or e");
        }
    }
}
