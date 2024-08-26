namespace DSAndAlgoConcepts.Tree
{
    internal class KthLevelOfTree
    {
        class Node
        {
            public int data;
            public Node left;
            public Node right;
            public Node(int data)
            {
                this.data = data;
            }
        }

        static void PrintKthLevelTreee(Node node, int level, int k)
        {
            if (node == null) return;
            if (level == k)
            {
                Console.WriteLine(node.data);
                return;
            }
            PrintKthLevelTreee(node.left, level + 1, k);
            PrintKthLevelTreee(node.right, level + 1, k);
        }
        //static void Main(string[] args)
        //{
        //    var root = new Node(1);
        //    root.left = new Node(2);
        //    root.right = new Node(3);
        //    root.left.left = new Node(4);
        //    root.left.right = new Node(5);
        //    root.right.left = new Node(6);
        //    root.right.right = new Node(7);


        //}
    }
}
