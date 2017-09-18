using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTCI.Moderate;

namespace CTCI._16._Moderate
{
    // Swap without temporary variable
    public class NumberSwapper
    {
        // a = 9, b = 5, a = a - b => 4, b = a + b => 4 + 5 = 9, a = b - a => 9 - 4 = 5
        public static Pair Swap(int a, int b)
        {
            a = a - b;
            b = a + b;
            a = b - a;

            Pair pair = new Pair(a, b);
            return pair;
        }

        // 2nd Method is using xor bit manipulation
        public static Pair SwapUsingXor(int a, int b)
        {
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;

            Pair pair = new Pair(a, b);
            return pair;
        }
    }

}
