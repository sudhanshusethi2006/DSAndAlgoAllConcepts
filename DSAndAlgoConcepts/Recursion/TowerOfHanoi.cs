namespace DSAndAlgoConcepts.Recursion
{
    internal class TowerOfHanoi
    {
        //static void Main(string[] args)
        //{
        //    TOH(3, 1, 3, 2);
        //}


        // Move n-1 Discs from A TO B using C
        // Move n th Disc from A to C
        //Move n-1 Discs from B TO C using A
        static void TOH(int n, int A, int C, int B)
        {
            if (n == 0) { return; }
            TOH(n - 1, A, B, C);
            Console.WriteLine($"Moving disc {n}th Disc from {A} to {C}");
            TOH(n - 1, B, C, A);
        }
    }
}
