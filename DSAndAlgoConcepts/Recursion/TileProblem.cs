namespace DSAndAlgoConcepts.Recursion
{
    internal class TileProblem
    {
        // area of floor = 2 Xn where 2 is the width of floow and n is the length

        // size of the tile 1 X 2 , where 1 is width and 2 is length 

        static int TilingProblem(int n)// n is the length
        {
            if (n == 1 || n == 0) return 1;
            int verticalWays = TilingProblem(n - 1);
            int HorizontalWays = TilingProblem(n - 2);
            return verticalWays + HorizontalWays;
        }

    }
}
