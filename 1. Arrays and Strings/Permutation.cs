using System.Collections.Generic;
using System.Linq;

namespace CTCI._1._Arrays_and_Strings
{
    // Checck if 2 string are permutations of each other. eg: Adi = diA = idA
    // String needs to have same number of characters
    // 2 ways to solve, one using Sorting the strings first and comparing them using 1 loop. 


    //Second method is adding each character and its occurence to a Hashmap (Dictionary) and decreasing the occurence when parsing the second string
    public class Permutation
    {
        // Wrong solution, cannot use as eg; 12 is both the sum of 2 and 10 and the sum of 3 and 9. With this algorithm "ad" would be a permutation of "bc".
        public static bool checkPermutationUsingAscii(string str1, string str2)
        {
            // First check if length is same, or return false immediately
            if (str1.Length != str2.Length)
            {
                return false;
            }

            int asciiSumStr1 = 0;
            int asciiSumStr2 = 0;

            for (int i = 0; i < str1.Length; i++)
            {
                char c = str1[i];
                asciiSumStr1 += c;
            }

            for (int i = 0; i < str2.Length; i++)
            {
                char c = str2[i];
                asciiSumStr2 += c;
            }

            if (asciiSumStr1 == asciiSumStr2)
            {
                return true;
            }
            return false;
        }

        public static bool checkPermutationUsingSort(string str1, string str2)
        {
            str1 = str1.Trim();
            str2 = str2.Trim();

            // First check if length is same, or return false immediately
            if (str1.Length != str2.Length)
            {
                return false;
            }

            string str1Sorted = new string(str1.OrderBy(c => c).ToArray());
            string str2Sorted = new string(str2.OrderBy(c => c).ToArray());

            for (int i = 0; i < str1Sorted.Length; i++)
            {
                if (str1Sorted[i] != str2Sorted[i])
                {
                    return false;
                }
            }
            return true;
        }

        // O(n) solution, although we are looping the strings individually once
        public static bool checkPermutationUsingHashMap(string str1, string str2)
        {
            str1 = str1.Trim();
            str2 = str2.Trim();

            // First check if length is same, or return false immediately
            if (str1.Length != str2.Length)
            {
                return false;
            }

            Dictionary<char, int> characterOccurencesDictionary = new Dictionary<char, int>();

            for (int i = 0; i < str1.Length; i++)
            {
                char c = str1[i];

                // If dictionary does not contain the character, add it. If it contains increase the occurence.
                if (!characterOccurencesDictionary.ContainsKey(c))
                {
                    characterOccurencesDictionary.Add(c, 1);
                }
                else
                {
                    int occurence = characterOccurencesDictionary[c];
                    characterOccurencesDictionary[c] = occurence + 1;
                }
            }

            // Now loop through second string to check if it matches
            for (int i = 0; i < str2.Length; i++)
            {
                char c = str2[i];

                // If dictionary does not contain the character, return false. If it contains deccrease the occurence.
                if (!characterOccurencesDictionary.ContainsKey(c))
                {
                    return false;
                }
                else
                {
                    int occurence = characterOccurencesDictionary[c];
                    characterOccurencesDictionary[c] = occurence - 1;
                }
            }

            // Now loop through dictionary just to check if there are any characters, with more than 1 occurence. If there are, return false. If not, return true.
            foreach (var value in characterOccurencesDictionary.Values)
            {
                if (value != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
