using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acronym_Generator_using_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true) // Loop until valid input is provided
                {
                    // Gather input from user
                    Console.Write("Please enter a phrase to convert to an acronym: ");
                    String input = Console.ReadLine();

                    // Check if input is empty
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Input cannot be empty. Please try again.");
                        Console.WriteLine();
                        continue; // Continue the loop to ask for input again
                    }

                    // Check for invalid characters
                    if (!IsInputValid(input))
                    {
                        Console.WriteLine("Input contains invalid characters. Please try again.");
                        Console.WriteLine();
                        continue; // Continue the loop to ask for input again
                    }

                    // Optional exclusions
                    String exclusions = input.Replace("and", "");
                    String[] wordArr = exclusions.Split(' ');

                    // Loop through sentence
                    String acronym = "";
                    for (int i = 0; i < wordArr.Length; i++)
                    {
                        if (wordArr[i] != "")
                        {
                            acronym += wordArr[i][0];
                        }
                    }
                    acronym = acronym.ToUpper();

                    Console.WriteLine("Your acronym is: " + acronym);
                    break; // Break the loop since valid input has been provided
                }
                Console.WriteLine();
                Console.WriteLine("Thank You");
                Console.WriteLine("Created by Akshay!!");
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
            }
        }

        // Function to check if input contains only valid characters
        static bool IsInputValid(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
