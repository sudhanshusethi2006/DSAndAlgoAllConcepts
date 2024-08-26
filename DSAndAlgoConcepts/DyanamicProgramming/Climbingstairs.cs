using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.DyanamicProgramming
{
    public class Climbingstairs
    {
        // 1 or 2 stairs at a time 
        //         __| 
        //       __|
        //    __|

        //static void Main(string[] args)
        //{
        //    // n=0 ways 1
        //    // n=1 ways 1
        //    // n=2 ways 2 
        //    var ans = ways_Recursion(5);
        //}


        //O(2^n)
        static int ways_Recursion(int n)
        {
            if (n == 0)
                return 1;
            if (n < 0)
                return 0;
            return ways_Recursion(n - 1) + ways_Recursion(n - 2);
        }

        //O(n)
        static int ways_Memoization(int n, int[] ways)
        {
            if (n == 0) return 1;
            if (n < 0) return 0;

            if (ways[n] > 0)
                return ways[n];
            ways[n] = ways_Memoization(n - 1, ways) + ways_Memoization(n - 2, ways);
            return ways[n];
        }

        //person can climb 1 or 2 or 3 stairs at a time
        //       __
        //      | 3
        //     __
        //    | 2
        //  __
        //__| 1
        //to get to step 3 we have 4 ways
        //111
        //12
        //21
        //3

        static int ways_Memoization_WithThirdjumpsAllowed(int n, int[] ways)
        {
            if (n == 0) return 1;
            if (n < 0) return 0;

            if (ways[n] > 0)
                return ways[n];
            ways[n] = ways_Memoization(n - 1, ways) + ways_Memoization(n - 2, ways) + ways_Memoization(n - 3, ways);
            return ways[n];
        }


        // Tabulation 

        // step1 : create table (could be arry) and initialize  the base case
        // step2 : meaning of index 
        // step3 : fill from small to large

        static int ways_Tabulation(int n)
        {
            int[] dp = new int[n + 1];
            dp[0] = 1;
            dp[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[n];
        }

    }
}
