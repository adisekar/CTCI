using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI._8._Recursion_and_Dynamic_Programming
{
    public class ReverseString
    {
        // str = Hello
        public static string Reverse(string str)
        {
            if (str.Length <= 1)
            {
                return str;
            }
            // Take first character
            var ch = str[0];
            var subStr = str.Substring(1, str.Length - 1);
            var reversedStr = Reverse(subStr) + ch;
            return reversedStr;
        }
    }
}
