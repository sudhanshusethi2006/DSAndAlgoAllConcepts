using System.Text;

namespace DSAndAlgoConcepts.Recursion
{
    internal class SubstringsUsingRecursion
    {
        //static void Main(string[] args)
        //{
        //    Print("Hello", 0);
        //    Console.WriteLine(new string('-', 40));
        //    Print2("Hello", 0);
        //    Console.WriteLine(new string('-', 40));
        //    PrintReverse("Hello", 0);
        //    Console.WriteLine(new string('-', 40));
        //    PrintReverse2("Hello", 0);
        //}
        static void Print(string str, int startIndex)
        {
            if (startIndex == str.Length) return;

            StringBuilder sb = new StringBuilder();
            for (int i = startIndex; i < str.Length; i++)
            {
                sb.Append(str[i]);
                Console.WriteLine(sb.ToString());
            }
            Print(str, startIndex + 1);
            Console.WriteLine("StartIndex ---> " + startIndex);
        }


        // wrong
        static void Print2(string str, int startIndex)
        {
            if (startIndex == str.Length) return;

            StringBuilder sb = new StringBuilder();
            for (int i = startIndex; i < str.Length; i++)
            {
                sb.Append(str[i]);
                Console.WriteLine(sb.ToString());
            }
            Print2(str, ++startIndex);
            Console.WriteLine("StartIndex ---> " + startIndex);
        }

        static void PrintReverse(string str, int startIndex)
        {

            if (startIndex == str.Length) return;
            PrintReverse(str, startIndex + 1);
            StringBuilder sb = new StringBuilder();
            for (int i = startIndex; i < str.Length; i++)
            {
                sb.Append(str[i]);
                Console.WriteLine(sb.ToString());
            }
            Console.WriteLine("StartIndex ---> " + startIndex);
        }


        // wrong
        static void PrintReverse2(string str, int startIndex)
        {

            if (startIndex == str.Length) return;
            startIndex++;
            PrintReverse2(str, startIndex);
            StringBuilder sb = new StringBuilder();
            for (int i = startIndex; i < str.Length; i++)
            {
                sb.Append(str[i]);
                Console.WriteLine(sb.ToString());
            }
            Console.WriteLine("StartIndex ---> " + startIndex);

        }
    }
}
