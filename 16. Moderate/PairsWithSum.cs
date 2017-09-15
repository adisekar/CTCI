using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI.Moderate
{
    // Pairs of integer in an array that sum to a specific value
    public class PairsWithSum
    {
        //1.  Brute Force - Compare each number with every other number in array. i and i + 1.
        // Complexity O(n^2) solution. Array need not be sorted. 
        public static List<Pair> PairsSumNaive(int[] array, int sum)
        {
            List<Pair> pairs = new List<Pair>();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == sum)
                    {
                        pairs.Add(new Pair { iValue = array[i], jValue = array[j] });
                    }

                }
            }
            return pairs;
        }

        //2.  Sort the Array. Use binary search method to find pairs
        // O(n logn) solution. Array needs to be sorted first. If we sort, indexes change, so we cant return indexes
        public static List<Pair> PairsSumSort(int[] array, int sum)
        {
            // Sorting the array O(n logn). Sorted in increasing order
            Array.Sort(array);

            int j = array.Length - 1;
            int i = 0;

            List<Pair> pairs = new List<Pair>();
            while (i < j)
            {
                if (array[i] + array[j] == sum)
                {
                    pairs.Add(new Pair { iValue = array[i], jValue = array[j] });
                    i++;
                }
                else if (array[i] + array[j] > sum)
                {
                    j--;
                }
                else if (array[i] + array[j] < sum)
                {
                    i++;
                }
            }
            return pairs;
        }

        //3. Calculate target value, target is specific value - current number
        // O(n) solution. Best Solution. Just loop once, and add element to set, if there is not a corresponding pair which add up to sum.
        public static List<Pair> PairsSumUsingSet(int[] array, int sum)
        {
            HashSet<int> seenSet = new HashSet<int>();
            List<Pair> result = new List<Pair>();

            for (int i = 0; i < array.Length; i++)
            {
                int target = sum - array[i];
                // If set does not contain complement element add it to set
                if (!seenSet.Contains(target))
                {
                    seenSet.Add(array[i]);
                }
                else
                {
                    result.Add(new Pair { iValue = target, jValue = array[i] });
                }
            }
            return result;
        }


        // [2,7,11,15] target = 9. Return [0,1]
        public static List<Pair> PairsSumReturnIndexes(int[] array, int sum)
        {
            Dictionary<int, int> seenSet = new Dictionary<int, int>();
            List<Pair> result = new List<Pair>();
            for (int i = 0; i < array.Length; i++)
            {
                int target = sum - array[i];
                // If set does not contain complement element add it to set
                if (!seenSet.ContainsKey(target))
                {
                    seenSet.Add(array[i], i);
                }
                else
                {
                    result.Add(new Pair(seenSet[target], i));
                }
            }
            return result;
        }
    }

    public struct Pair
    {
        public int iValue { get; set; }
        public int jValue { get; set; }

        public Pair(int i, int j)
        {
            iValue = i;
            jValue = j;
        }
    }
}
