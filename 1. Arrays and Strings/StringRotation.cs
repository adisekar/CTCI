using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI._1._Arrays_and_Strings
{
    public class StringRotation
    {
        // s1 = waterbottle, s2 = erbottlewat. Output is true
        public static bool IsRotation(string s1, string s2)
        {
            if (s1.Length == s2.Length)
            {
                // Add s1 + s1 = waterbottlewaterbottle
                string s1s1 = s1 + s1;
                var result = s1s1.Substring(s1s1.IndexOf(s2), s2.Length);
                return result.Length > 0 ? true : false;
            }
            return false;
        }
    }
}
