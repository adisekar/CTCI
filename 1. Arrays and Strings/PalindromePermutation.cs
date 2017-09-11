using System.Collections.Generic;
using System.Linq;

namespace CTCI._1._Arrays_and_Strings
{
    public class PalindromePermutation
    {
        public static bool CheckIfPermuationOfPalindrome(string input, List<string> outputList)
        {
            // Check if Output string is same length of input
            // Check if Output string is palindrome
            // Check if Output string and input string is same characters

            foreach (var output in outputList)
            {
                if (output.Length != input.Length)
                {
                    return false;
                }

                if (IsPalindrome(output))
                {
                    if (!IsPermutation(input, output))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static bool IsPalindrome(string input)
        {
            var charArray = input.ToCharArray();
            var endIndex = input.Length - 1;

            for (int i = 0; i < input.Length / 2; i++, endIndex--)
            {
                if (charArray[i] != charArray[endIndex])
                {
                    return false;
                }
            }
            return true;
        }

        private static bool IsPermutation(string input, string output)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            foreach (char ch in input)
            {
                if (!dictionary.ContainsKey(ch))
                {
                    dictionary.Add(ch, 1);
                }
                else
                {
                    int occurence = dictionary[ch];
                    dictionary[ch] = occurence + 1;
                }
            }

            foreach (char ch in output)
            {
                if (!dictionary.ContainsKey(ch))
                {
                    return false;
                }
                else
                {
                    int occurence = dictionary[ch];
                    dictionary[ch] = occurence - 1;
                }
            }

            return dictionary.Values.All(v => v == 0);
        }
    }
}
