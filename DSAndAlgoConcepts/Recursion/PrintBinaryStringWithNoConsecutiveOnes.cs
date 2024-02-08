namespace DSAndAlgoConcepts.Recursion
{
    internal class PrintBinaryStringWithNoConsecutiveOnes
    {
        static void Main(string[] args)
        {
            Print(3, 0, "");
        }

        static void Print(int n, int lastPlace, string s)
        {
            if (n == 0)
            {
                Console.WriteLine(s);

                return;
            }

            Print(n - 1, 0, s + "0");
            if (lastPlace == 0)
                Print(n - 1, 1, s + "1");
        }
    }
}
