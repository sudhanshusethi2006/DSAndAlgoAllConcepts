namespace DSAndAlgoConcepts.BackTracking
{
    internal class GridWaysClass
    {
        // ---> can go right
        //  can go down
        //static void Main(string[] args)
        //{
        //    //m x n 
        //    int n = 5;
        //    int m = 4;
        //    var TotalWays = GridWays(0, 0, m, n);
        //    Console.WriteLine(TotalWays);
        //    var TotalWaysByFactorial = GridWaysByPermutationFormula(m, n);
        //    Console.WriteLine(TotalWaysByFactorial);
        //}

        static int GridWays(int i, int j, int m, int n)
        {
            if (i == m - 1 && j == n - 1)
            {
                return 1;

            }
            if (i == m || j == n)
                return 0;

            int Down_ways = GridWays(i + 1, j, m, n);
            int Right_ways = GridWays(i, j + 1, m, n);

            return Down_ways + Right_ways;
        }

        static int GridWaysByPermutationFormula(int m, int n)
        {
            // total steps to reach destination in a single way= m-1 + n-1

            //for 3 X 3
            // DDRR ( m-1 + n-1 steps
            // DRDR
            // DRRD


            //repeating 
            // n-1 
            //m-1

            // (n-1 + m-1 ) ! / (n-1)!
            // +-* (m-1)! 

            return Factorial(n - 1 + m - 1) / (Factorial(n - 1) * Factorial(m - 1));

        }

        static int Factorial(int n)
        {
            if (n == 0 || n == 1) return 1;

            return n * Factorial(n - 1);
        }

    }
}
