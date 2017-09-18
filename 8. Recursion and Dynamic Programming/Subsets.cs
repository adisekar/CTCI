using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI._8._Recursion_and_Dynamic_Programming
{
    public class Subsets
    {
        // Time Complexity is O(2^n) exponential solution. If 5 numbers are passed in we get 2^5. No way around for better solution
        // number list is the original list of numbers passed in
        // Subset list is a collection of subsets eg: {}, {1,2}, {1}. Each of {}, {1}, is its own List<int>
        public static void GetAllSubsets(List<List<int>> subsetList, List<int> numberList)
        {
            // If list is empty, add empty set to list
            if (!numberList.Any())
            {
                subsetList.Add(new List<int> { });
                return;
            }

            // Remove first number from list, and find all subsets for remanining, and then finally add this number back. 
            int currentNumber = numberList[0];
            numberList.Remove(currentNumber);

            // This is recursive case
            GetAllSubsets(subsetList, numberList);

            // Add the subset list to iterating list to iterate over, and add the earlier removed number
            List<List<int>> iteratingList = new List<List<int>>();
            iteratingList.AddRange(subsetList);

            foreach (List<int> item in iteratingList)
            {
                // We add the existing items in the subset to the new set, and then add the removed number, and finally add them to the subsetlist
                List<int> newSubset = new List<int>();
                newSubset.AddRange(item);
                newSubset.Add(currentNumber);
                subsetList.Add(newSubset);
            }
        }
    }
}
