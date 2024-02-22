using System.Text;

namespace DSAndAlgoConcepts.Strings
{

    internal class PrintSubStrings
    {
        //static void Main(string[] args)
        //{
        //    Print("Hello");
        //    PrintWithoutStringBuilder("Hello");
        //}
        static void Print(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int j = i; j < str.Length; j++)
                {
                    sb.Append(str[j]);
                    Console.WriteLine(sb.ToString());
                }
            }
        }

        static void PrintWithoutStringBuilder(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {

                for (int j = i; j < str.Length; j++)
                {

                    for (int k = i; k <= j; k++)
                    {
                        Console.Write(str[k]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
