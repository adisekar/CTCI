using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI._8._Recursion_and_Dynamic_Programming
{
    public class TripleStep
    {
        public static int CountStepsRecursive(int steps)
        {
            // For negative it is 0
            if (steps < 0)
            {
                return 0;
            }
            // If you are at the top step, step 0, then there is 1 path
            else if (steps == 0)
            {
                return 1;
            }
            else
            {
                return CountStepsRecursive(steps - 1) + CountStepsRecursive(steps - 2) + CountStepsRecursive(steps - 3);
            }
        }

        public static int CountStepsRecursiveDp(int steps, int[] memo)
        {
            // For negative it is 0
            if (steps < 0)
            {
                return 0;
            }
            // If you are at the top step, step 0, then there is 1 path
            else if (steps == 0)
            {
                return 1;
            }
            // Initially all values in array are 0 by default
            else if (memo[steps] > 0)
            {
                return memo[steps];
            }
            else // If memo table value is 0
            {
                memo[steps] = CountStepsRecursiveDp(steps - 1, memo) + CountStepsRecursiveDp(steps - 2, memo) + CountStepsRecursiveDp(steps - 3, memo);
                return memo[steps];
            }
        }

        // Iterative approach
        public static int CountStepsIterativeDp(int steps)
        {
            // For negative it is 0
            if (steps < 0)
            {
                return 0;
            }
            // 1 or 0
            if (steps <= 1)
            {
                return 1;
            }

            int[] paths = new int[steps + 1];
            paths[0] = 1;
            paths[1] = 1;
            paths[2] = 2;

            for (int i = 3; i <= steps; i++)
            {
                paths[i] = paths[i - 1] + paths[i - 2] + paths[i - 3];
            }
            return paths[steps];
        }

        // Only using 3 space elements. Constant space. Dont need to store all items
        public static int CountStepsIterativeConstantSpace(int steps)
        {
            // For negative it is 0
            if (steps < 0)
            {
                return 0;
            }
            // If you are at the top step, step 0, then there is 1 path
            if (steps <= 1)
            {
                return 1;
            }
            int[] paths = { 1, 1, 2 };

            for (int i = 3; i <= steps; i++)
            {
                int count = paths[0] + paths[1] + paths[2];
                paths[0] = paths[1];
                paths[1] = paths[2];
                paths[2] = count;
            }
            return paths[2];
        }
    }
}
