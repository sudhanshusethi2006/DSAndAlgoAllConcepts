using System.Text;

namespace DSAndAlgoConcepts.SimpleConcepts
{
    internal class BinaryConversion
    {
        //static void Main(string[] args)
        //{
         
        //    long l = 22;
        //    float f = l;
        //    Console.Write(3f);
        //    var ans = DecimalTOBinary(7);
        //    var ans2 = DecimalTOBinaryWithoutstack(7);
        //}
        public static int DecimalTOBinary(int n)
        {
            if (n <= 1) return n;

            var st = new Stack<string>();

            while (n > 0)
            {
                var binaryDigit = n % 2;
                st.Push(binaryDigit.ToString());
                n = n / 2;
            }


            StringBuilder sb = new StringBuilder();

            foreach (var item in st)
            {
                sb.Append(item.ToString());
            }

            return int.Parse(sb.ToString());
        }

        public static int DecimalTOBinaryWithoutstack(int n)
        {
            if (n <= 1) return n;

            var binNum = 0;
            int pow = 0;

            while (n > 0)
            {
                var binaryDigit = n % 2;
                binNum += binaryDigit * (int)Math.Pow(10, pow++);
                n = n / 2;
            }


            return binNum;
        }


    }
}
