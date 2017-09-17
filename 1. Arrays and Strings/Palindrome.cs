using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI._1._Arrays_and_Strings
{
    public class Palindrome
    {
        public static bool IsPalindromeNaive(string str)
        {
            str = str.ToLower().Replace(" ", "").Replace(".", "").Replace(",", "");
            int strLength = str.Length - 1;

            for (int i = 0; i < str.Length / 2; i++, strLength--)
            {
                if (str[i] != str[strLength])
                {
                    return false;
                }
            }
            return true;
        }

        // To compare strings having white spaces inbetween 
        public static bool IsPalindrome(string str)
        {
            // str = str.ToLower().Replace(" ", "").Replace(".", "").Replace(",", "");
            str = str.ToLower();
            int strLength = str.Length - 1;
            int i = 0;
            while (i <= strLength)
            {
                char frontCharacter = str[i];
                char backCharacter = str[strLength];

                while (frontCharacter == ' ' || frontCharacter == '.' || frontCharacter == ',')
                {
                    i++;
                    frontCharacter = str[i];
                }

                while (backCharacter == ' ' || backCharacter == '.' || backCharacter == ',')
                {
                    strLength--;
                    backCharacter = str[strLength];
                }

                // Actual Check
                if (frontCharacter != backCharacter)
                {
                    return false;
                }

                i++;
                strLength--;
            }

            return true;
        }
    }
}
