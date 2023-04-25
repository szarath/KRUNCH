﻿using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Krunch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a line of input: ");
            string input = Console.ReadLine();
            string krunched = Krunch(input);
            Console.WriteLine("Krunched: " + krunched);
        }

        public static string Krunch(string input)
        {
            // Define vowels and punctuation to be removed
            char[] vowels = { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };
            char[] punctuation = { ',', '?', ';', ':' };

            // Create a StringBuilder to hold the krunched input
            StringBuilder krunched = new StringBuilder();

            // Loop through each character in the input
            foreach (char c in input)
            {
                // Check if the character is a vowel or punctuation
                if (vowels.Contains(c) || punctuation.Contains(c))
                {
                    // Skip vowels and punctuation
                    continue;
                }

                // Check if the character is a space
                if (c == ' ')
                {
                    // Append the space to the krunched string
                    krunched.Append(c);
                    continue;
                }

                // Check if the krunched string already contains the character
                if (krunched.ToString().ToUpper().Contains(char.ToUpper(c)))
                {
                    // Skip repeated characters
                    continue;
                }

                // Add the character to the krunched string
                krunched.Append(c);
            }

            // Remove any remaining punctuation
            for (int i = 0; i < punctuation.Length; i++)
            {
                krunched.Replace(punctuation[i].ToString(), "");
            }

            // Replace multiple spaces with a single space using regular expression
            string result = Regex.Replace(krunched.ToString(), @"\s+", " ");

            // Return the final krunched string
            return result.ToUpper().Trim();
        }
    }
}
