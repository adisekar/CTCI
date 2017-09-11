using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI._1._Arrays_and_Strings
{
    public class UrLify
    {
        // Mr John Smith = Mr%20John%20Smith
        public static string GetEncodedURL(string input, int length)
        {
            // Trim to length of string. To DO
            string trimmedInput = input.Trim();

            string[] words = trimmedInput.Split(' ');
            return string.Join("%20", words);
        }

        // Mr John Smith = Mr%20John%20Smith
        public static string GetEncodedURLusingChar(string input, int length)
        {
            int spaceCount = 0;
            // Count number of spaces
            for (int i = 0; i < length; i++)
            {
                char ch = input[i];
                if (ch == ' ')
                {
                    spaceCount++;
                }
            }

            int index = length + spaceCount * 2;
            char[] characters = input.ToCharArray();
            char[] result = new char[index];

            for (int i = length - 1; i >= 0; i--)
            {
                // If space, replace with %20
                if (characters[i] == ' ')
                {
                    result[index - 1] = '0';
                    result[index - 2] = '2';
                    result[index - 3] = '%';
                    index = index - 3;
                }
                else
                {
                    result[index - 1] = characters[i];
                    index--;
                }
            }
            return new string(result);
        }
    }
}
