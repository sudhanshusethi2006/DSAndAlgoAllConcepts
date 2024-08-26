using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.DyanamicProgramming
{
    internal class Knapsack
    {

           // 0-1 Knapsack

        // Fractional Knapsack is Greedy 

        // Unbounded Knapsack

        //------------------------------


        // 0-1 Knapsack

        //int[] val= {15,14,10,45,30}
        // int[] Weight = {2,5,1,3,4}
        // total Weight allowed =7
        // ans = max Profit


        static void Main(string[] args)
        {

            int[] val = new int[] { 15, 14, 10, 45, 30 };
            int[] Weight = new int[] { 2, 5, 1, 3, 4 };
            int W = 7;
            int n = val.Length;
            var res = Max_val_Knapsack(val, Weight, W, n);


            // 2d array

            // X is n+ 1
            // Y is W + 1
            // dp = new int[W+1, n+1]; 
            var dp = new int[n + 1, W + 1];
            for (int i = 0; i < dp.GetLength(0); i++)
            {
                for (int j = 0; j < dp.GetLength(1); j++)
                {
                    dp[i, j] = -1;
                }
            }
            var resWithDp = max_val_knapsack_memoization(val, Weight, W, n, dp);

        }

        static int Max_val_Knapsack(int[] val, int[] weight, int W, int n)
        {
            if (n == 0 || W == 0)
                return 0;

            // 

            if (weight[n - 1] <= W)
            {
                var ans1 = val[n - 1] + Max_val_Knapsack(val, weight, W - weight[n - 1], n - 1);
                var ans2 = Max_val_Knapsack(val, weight, W, n - 1);
                return Math.Max(ans1, ans2);
            }
            return Max_val_Knapsack(val, weight, W, n - 1);
        }

        static int max_val_knapsack_memoization(int[] val, int[] weight, int W, int n, int[,] dp)
        {
            // Complexity n * w
            // 2d array

            // X is n+ 1
            // Y is W + 1
            // dp = new int[W+1, n+1]; 


            if (n == 0 || W == 0)
                return 0;

            if (dp[n, W] != -1)
                return dp[n, W];
            // 

            if (weight[n - 1] <= W)
            {
                var ans1 = val[n - 1] + max_val_knapsack_memoization(val, weight, W - weight[n - 1], n - 1, dp);
                var ans2 = max_val_knapsack_memoization(val, weight, W, n - 1, dp);
                dp[n, W] = Math.Max(ans1, ans2);
                return dp[n, W];
            }
            dp[n, W] = max_val_knapsack_memoization(val, weight, W, n - 1, dp);
            return dp[n, W];
        }

        //static int max_val_knapsack_Tabulation(int[] val, int[] weight, int W, int n)
        //{
        //    // create table

        //    // fill bottom up, smallto large

        //    var dp = new int[n + 1, W + 1];

        //}
    }
}
