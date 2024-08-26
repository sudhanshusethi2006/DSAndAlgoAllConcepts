namespace DSAndAlgoConcepts.Test
{

    public class Test1
    {
        public virtual int sum(int x, int y)
        {
            return x + y;
        }

        //public abstract int Subtract(int x, int y);

    }


    internal class ReflectionExamples : Test1
    {
        public override int sum(int x, int y)
        {
            return x - y;
        }
    }

    internal class MainClass
    {
        //static void Main(string[] args)
        //{
        //    var res = ReturnFirstList();
        //    HashSet<string> list = new HashSet<string>();
        //    list.Add("sudhanshu");
        //    list.Add("sudhanshu1");
        //    Dictionary<int, int> dict = new Dictionary<int, int>();
        //    Hashtable hashtable = new Hashtable();



        //}

        static List<first> ReturnFirstList()
        {
            var result = new List<first>();

            result.Add(new first(1));
            using (var f = new first(2))
            {
                result.Add(f);
            }

            return result;
        }
    }



    public class first : IDisposable
    {
        public first(int x)
        {
            this.x = x;
        }
        public int? x { get; set; }
        public int? y { get; set; }

        // public string Getname => "sudhanshu";
        public void Dispose()
        {
            this.x = null;
            this.y = null;
            //GC.SuppressFinalize(this);
        }

        public int[] GetArray()
        {
            return new int[2] { x.Value, y.Value };
        }
    }

    //public class second
    //{

    //    public second(first obj)
    //    {
    //        this.obj = obj;
    //    }

    //    public void AssignObj2(first obj)
    //    {
    //        obj2 = new first();
    //        obj2.y = obj.y;
    //        obj2.x = obj.x;
    //    }


    //    public first obj { get; set; }

    //    public first obj2 { get; set; }
    //}
    //internal class ReflectionExamples
    //{
    //    static int[] arr;
    //    static second GetSecond()
    //    {
    //        using (first f = new first())
    //        {
    //            //first f = new first();
    //            f.y = 1;
    //            f.x = 2;
    //            arr = f.GetArray();
    //            var sec = new second(f);
    //            //sec.AssignObj2(f);

    //            return sec;
    //        }
    //    }

    //    static void Main(string[] args)
    //    {

    //        var sec = GetSecond();

    //        var arr2 = arr;
    //        string str = "sudhanshu";

    //        int count = 0;

    //        foreach (char c in str)
    //        {
    //            count += c - 96;
    //        }
    //        int temp = 0;
    //        while (count > 9)
    //        {
    //            temp += count % 10;
    //            count /= 10;
    //        }
    //        temp += count;

    //        Console.WriteLine(temp);
    //    }

    //}
}
