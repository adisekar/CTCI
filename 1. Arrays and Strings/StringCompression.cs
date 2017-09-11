using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI._1._Arrays_and_Strings
{
    // Also called Run length Encoding
    public class StringCompression
    {
        // aabcccccaaa = a2b1c5a3
        public static string GetCompressed(string input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length - 1;)
            {
                int lengthEncoding = 1;
                while (i + 1 < input.Length && input[i] == input[i + 1])
                {
                    lengthEncoding++;
                    i++;
                }
                sb.Append(input[i]);
                i++;

                if (lengthEncoding >= 1)
                {
                    sb.Append(lengthEncoding);
                }
            }

            // Only return compresses string, if it is shorter than original string
            return sb.Length < input.Length ? sb.ToString() : input;
        }
    }
}
