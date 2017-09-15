using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI.Hard
{
    public class CountOf2s
    {
        public static int NumberOf2sInRange(int n)
        {
            int count = 0;
            for (int i = 2; i <= n; i++)
            {
                count += NumberOf2s(i);
            }
            return count;
        }

        // Count the number of 2s in a single number
        // 25 => 25 % 10 = 5, 25 / 10 = 2, 2 % 10 == 2 True. One 2 is present
        private static int NumberOf2s(int n)
        {
            int count = 0;
            while (n > 0)
            {
                if (n % 10 == 2)
                {
                    count++;
                }
                n = n / 10;
            }
            return count;
        }
    }
}
