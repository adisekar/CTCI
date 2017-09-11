using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI._1._Arrays_and_Strings
{
    public class OneAway
    {
        // String can have 3 operations, insert, delete, replace 1 character
        public static bool IsOneAway(string str1, string str2)
        {
            if (str1.Length == str2.Length)
            {
                return OneEditReplace(str1, str2);
            }
            if (str1.Length - 1 == str2.Length)
            {
                return OneEditInsert(str1, str2);
            }
            if (str1.Length + 1 == str2.Length)
            {
                return OneEditInsert(str1, str2);
            }
            return false;
        }

        private static bool OneEditInsert(string str1, string str2)
        {
            int index1 = 0;
            int index2 = 0;

            while (index1 < str1.Length && index2 < str2.Length)
            {
                if (str1[index1] != str2[index2])
                {
                    if (index1 != index2)
                    {
                        return false;
                    }
                    index1++;
                }
                else // When they are both equal, move to next character
                {
                    index1++;
                    index2++;
                }
            }
            return true;
        }

        private static bool OneEditReplace(string str1, string str2)
        {
            var foundDifference = false;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    foundDifference = true;
                }
            }
            return foundDifference;
        }


        // 2nd Method
        public static bool IsOneAway2(string str1, string str2)
        {
            // Check Lengths if > 1
            if (Math.Abs(str1.Length - str2.Length) > 1)
            {
                return false;
            }

            // Get Shorter and Longer Strings
            //string longerStr = str1.Length > str2.Length ? str1 : str2;
            //string shorterStr = str1.Length > str2.Length ? str2 : str1;

            int index1 = 0;
            int index2 = 0;
            bool foundDifference = false;

            while (index1 < str1.Length && index2 < str2.Length)
            {
                if (str1[index1] != str2[index2])
                {
                    // IF first difference found, change to true. If more than 1, return false
                    if (foundDifference)
                    {
                        return false;
                    }
                    foundDifference = true;

                    // Character has been replaced
                    if (str1.Length == str2.Length)
                    {
                        index1++;
                        index2++;
                    }
                    else
                    {
                        index1++;
                    }
                }
                else // When they are both equal, move to next character
                {
                    index1++;
                    index2++;
                }
            }
            return true;
        }


        //public static void Main(string[] args)
        //{
        //    OneAway.IsOneAway2("pale", "ple");
        //}
    }
}
