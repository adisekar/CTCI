using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI._1._Arrays_and_Strings
{
    public class Unique
    {
        public static bool IsUniqueCharacters(string str)
        {
            // Ascii is 128, extended ascii is another 128. So total is 256 to be safe
            bool[] charSet = new bool[256];

            foreach (char ch in str)
            {
                int val = (int)ch;

                if (charSet[val])
                {
                    return false;
                }
                charSet[val] = true;
            }
            return true;
        }
    }
}
