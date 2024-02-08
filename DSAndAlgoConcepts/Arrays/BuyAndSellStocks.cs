namespace DSAndAlgoConcepts.Arrays
{
    internal class BuyAndSellStocks
    {
        //public static void Main(string[] args)
        //{
        //    int[] prices = { 7, 1, 5, 3, 6, 4 };
        //    int maxProfit= MaxProfitMaxAndSellStocks(prices);
        //}

        public static int MaxProfitMaxAndSellStocks(int[] prices)
        {
            int leastBuyPrice = prices[0];
            int maxProfit = 0;
            for (int i = 1; i < prices.Length; i++)
            {

                if (leastBuyPrice < prices[i])
                {
                    int profit = prices[i] - leastBuyPrice;
                    maxProfit = Math.Max(profit, maxProfit);
                }
                else
                {
                    leastBuyPrice = prices[i];
                }

            }

            return maxProfit;
        }




    }

}
