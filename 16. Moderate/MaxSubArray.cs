using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI._16._Moderate
{
    public class MaxSubArray
    {
        // Array can contain negative and positive integers. 
        public static int LargestContinousSum(int[] arr)
        {
            // Important. Start by assigning first value of array, not 0
            int maxSum = arr[0];
            int currentSum = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                // If current sum is greater than previous max sum, assign this to max sum
                currentSum = Math.Max(currentSum + arr[i], arr[i]);
                maxSum = Math.Max(maxSum, currentSum);
            }
            return maxSum;
        }
    }
}
