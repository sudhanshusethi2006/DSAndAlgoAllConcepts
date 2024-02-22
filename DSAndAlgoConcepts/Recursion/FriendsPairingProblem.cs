namespace DSAndAlgoConcepts.Recursion
{
    // make pairs of friends 
    // total ways= single + total pairs of 2 
    // n=1 ways =1
    // n=2 ways (A, B),( AB) ; ways=2
    // n=3 ways (A,B,C),(A,B), (A,C), (b,C) ; ways =4
    internal class FriendsPairingProblem
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(FriendPairing(4));
        //}
        static int FriendPairing(int n)
        {
            if (n == 1 || n == 2) return n;

            var Singlechoice = FriendPairing(n - 1);
            var Pairchoices = n - 1 * FriendPairing(n - 2);
            int total = Singlechoice + Pairchoices;
            return total;


        }
    }
}
