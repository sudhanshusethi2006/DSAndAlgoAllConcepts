using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.DyanamicProgramming
{
    public class FibonacciSeries
    {
        //static void Main(string[] args)
        //{
        //    // 0,1,1,2,3,5,8,13

        //    var ans = Fibonacci(5);
        //    int[] mem = new int[6];
        //    mem[0] = 0;
        //    mem[1] = 1;
        //    var ans2 = FibonacciWithDP(5, mem);
        //}
    
        static int Fibonacci(int n)
        {
        
            if (n == 0 || n == 1) return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static int FibonacciWithDP(int n, int[] arr)
        {

            if (n == 0 || n == 1) return n;
            if (arr[n]==0)
            {
                arr[n] = FibonacciWithDP(n - 1, arr) + FibonacciWithDP(n - 2, arr);
            }
                      
            return arr[n];
        }


        static int FibonacciWithtTabulation(int n)
        {
            int[] dp = new int[n + 1];
            dp[0] = 0;
            dp[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                dp[i]= dp[i-1]+ dp[i-2];
            }
            return dp[n];
        }
    }
}
