using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.Stack
{
    internal class StockSpanProblem
    {
        //static void Main(string[] args)
        //{
        //    int[] stocks = { 100, 80, 60, 70, 60, 85, 100 };
        //    int[] span = new int[stocks.Length];
        //    stockSpan(stocks, span);

        //    Console.WriteLine(string.Join(" ", span));

        //}

        Stack<KeyValuePair<int, int>> stack = new Stack<KeyValuePair<int, int>>();
        public int Next(int price)
        {
            int span = 1;
            while (stack.Count > 0 && stack.Peek().Key <= price)
            {
                span += stack.Pop().Value;

            }
            stack.Push(new KeyValuePair<int, int>(price, span));
            return span;
        }

        static void NaiveSolution(int[] stocks, int[] span)
        {
            span[0] = 1;
            for (int i = 1; i < stocks.Length; i++)
            {
                int span_today = 1;
                for (int j = i - 1; j >= 0 && stocks[i] >= stocks[j]; j--)
                {

                    span_today++;

                }
                span[i] = span_today;

            }
        }

        static void stockSpan(int[] stocks, int[] span)
        {
            Stack<int> stack = new Stack<int>();
            span[0] = 1;
            stack.Push(0);

            for (int i = 1; i < stocks.Length; i++)
            {
                int currentPrice = stocks[i];
                while (stack.Count > 0 && currentPrice >= stocks[stack.Peek()])
                {
                    stack.Pop();

                }

                if (stack.Count == 0)
                {
                    span[i] = i + 1;
                }

                else
                {
                    int prevHigh = stack.Peek();
                    span[i] = i - prevHigh;
                }

                stack.Push(i);
            }
        }
    }
}
