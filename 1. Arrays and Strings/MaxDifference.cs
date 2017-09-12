using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI._1._Arrays_and_Strings
{
    public class MaxDifference
    {
        // Max Difference in Array
        // [2,3,10,6,4,8,1] Output - 8, difference between 10 and 2
        // [7,9,5,6,3,2] Output is 2, difference bewtween 7 and 9
        public static int MaxDifferenceNaive(int[] array)
        {
            int maxDifference = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] - array[i] > maxDifference)
                    {
                        maxDifference = array[j] - array[i];
                    }
                }
            }
            return maxDifference;
        }

        // O(n) great solution. Use 2 variables maxDifference and minElement
        public static int MaxDifference2(int[] array)
        {
            int maxDifference = array[1] - array[0];
            int minElement = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] - minElement > maxDifference)
                {
                    maxDifference = array[i] - minElement;
                }

                if (minElement > array[i])
                {
                    minElement = array[i];
                }
            }
            return maxDifference;
        }
    }
}
