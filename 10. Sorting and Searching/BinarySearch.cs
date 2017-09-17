using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI._10._Sorting_and_Searching
{
    public class BinarySearch
    {
        public static int BinarySearchIterative(int[] sortedList, int searchNumber)
        {
            int min = 0;
            int max = sortedList.Length - 1;
            int midPt = (min + max) / 2;

            while (min <= max)
            {
                midPt = (min + max) / 2;
                if (sortedList[midPt] == searchNumber)
                {
                    return midPt;
                }

                if (sortedList[midPt] > searchNumber)
                {
                    max = midPt - 1;
                }
                else
                {
                    min = midPt + 1;
                }
            }
            return midPt;
        }

        public static int BinarySearchRecursive(int[] sortedList, int searchNumber, int min, int max)
        {
            if (min > max)
            {
                return -1;
            }
            int midPt = (min + max) / 2;

            if (sortedList[midPt] == searchNumber)
            {
                return midPt;
            }

            if (sortedList[midPt] > searchNumber)
            {
                max = midPt - 1;
                return BinarySearchRecursive(sortedList, searchNumber, min, max);
            }
            else
            {
                min = midPt + 1;
                return BinarySearchRecursive(sortedList, searchNumber, min, max);
            }
        }
    }
}
