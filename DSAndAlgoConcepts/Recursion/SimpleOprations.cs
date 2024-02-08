namespace DSAndAlgoConcepts.Recursion
{
    internal class SimpleOprations
    {
        //static void Main(string[] args)
        //{
        //    ispalindrome(121);
        //    printnumbersdecreasingorder(5);
        //    Console.writeline(new string('_', 10));
        //    printnumbersascendingorder(1);
        //    Console.writeline(new string('_', 10));
        //    Console.writeline(factorial(10));
        //    Console.writeline(new string('_', 10));
        //    Console.writeline(printsumofnaturalnumbers(10));
        //    Console.writeline(new string('_', 10));
        //    console.writeline(fibonacci(4));


        //    console.writeline(lastoccurence(new int[] { 5, 5, 5, 5, 5 }, 0, 5));

        //    Console.WriteLine(PrintXToThePowerN(2, 10));
        //    Console.WriteLine(PrintXToThePowerN_Optimized(2, 10));
        //}



        public static bool IsPalindrome(int x)
        {
            var s = x.ToString();
            var s2 = new string(x.ToString().Reverse().ToArray());
            return x.ToString() == new string(x.ToString().Reverse().ToArray());
        }
        static void PrintNumbersDecreasingOrder(int n)
        {
            string s = "";
            var s2 = s.Reverse();
            if (n == 0) return;
            Console.WriteLine(n);
            PrintNumbersDecreasingOrder(n - 1);
        }

        static void PrintNumbersAscendingOrder(int n)
        {
            if (n == 6) return;
            Console.WriteLine(n);
            PrintNumbersAscendingOrder(n + 1);
        }

        static double Factorial(int n)
        {
            if (n <= 1) return 1;
            return n * Factorial(n - 1);
        }

        static int PrintSumOfNaturalNumbers(int n)
        {
            if (n == 1) return 1;
            int sum = n + PrintSumOfNaturalNumbers(n - 1);
            return sum;
        }

        static int Fibonacci(int n)
        {
            if (n == 0 || n == 1) return n;
            int sum = Fibonacci(n - 1) + Fibonacci(n - 2);
            return sum;
        }

        static int LastOccurence(int[] arr, int i, int key)
        {
            if (i == arr.Length) return -1;
            int isFound = LastOccurence(arr, i + 1, key);
            if (isFound == -1 && arr[i] == key) return i;
            return isFound;
        }

        //x^n O(n)
        static int PrintXToThePowerN(int x, int n)
        {
            if (n == 0) return 1;
            return x * PrintXToThePowerN(x, n - 1);

        }

        //x^n O(logn)
        static int PrintXToThePowerN_Optimized(int x, int n)
        {
            if (n == 0) return 1;
            var half = PrintXToThePowerN_Optimized(x, n / 2);
            var halfPower = half * half;
            if (n % 2 != 0)
            {
                return x * halfPower;
            }

            return halfPower;
        }
    }
}
