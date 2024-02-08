namespace DSAndAlgoConcepts.Arrays
{
    internal class TrappingRainwater
    {
        private static int[] heightsOfBars;
        private static int[] maxLeftWaterHeights;
        private static int[] maxRightWaterHeights;
        //static void Main(string[] args)
        //{
        //    int[] heights = { 4, 2, 0, 6, 3, 2, 5 };
        //    heightsOfBars = new int[] { 4, 2, 0, 6, 3, 2, 5 };
        //    maxLeftWaterHeights = new int[heights.Length];
        //    maxRightWaterHeights = new int[heights.Length];
        //    var totalWater = TotalWaterTraped();
        //    Console.WriteLine(totalWater.ToString());
        //}

        static int TotalWaterTraped()
        {
            CalculatemaxLeftWaterHeights();
            CalculatemaxRightWaterHeights();
            int sum = 0;
            for (int i = 0; i < heightsOfBars.Length; i++)
            {
                var maxWaterOnBar = Math.Min(maxLeftWaterHeights[i], maxRightWaterHeights[i]);
                var actalWaterOnBar = maxWaterOnBar - heightsOfBars[i];
                sum += actalWaterOnBar;
            }
            return sum;
        }

        static void CalculatemaxLeftWaterHeights()
        {
            maxLeftWaterHeights[0] = heightsOfBars[0];
            for (int i = 1; i < heightsOfBars.Length; i++)
            {
                maxLeftWaterHeights[i] = Math.Max(heightsOfBars[i], maxLeftWaterHeights[i - 1]);
            }
        }

        static void CalculatemaxRightWaterHeights()
        {
            maxRightWaterHeights[heightsOfBars.Length - 1] = heightsOfBars[heightsOfBars.Length - 1];
            for (int i = heightsOfBars.Length - 2; i >= 0; i--)
            {
                maxRightWaterHeights[i] = Math.Max(heightsOfBars[i], maxRightWaterHeights[i + 1]);
            }
        }
    }
}
