namespace DSAndAlgoConcepts.BinarySearchTree
{
    internal class PrintInRange
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
        //static void Main(string[] args)
        //{
        //    int[] values = { 8, 5, 3, 1, 4, 6, 10, 11, 14 };
        //    Node root = null;

        //    for (int i = 0; i < values.Length; i++)
        //    {
        //        root = Insert(root, values[i]);
        //    }


        //    int k1 = 5;
        //    int k2 = 12;

        //    PrintInRangeofBST(root, k1, k2);
        //}

        static Node Insert(Node root, int data)
        {
            if (root == null)
            {
                root = new Node(data);
                return root;
            }
            if (root.data > data)
                root.left = Insert(root.left, data);

            else
                root.right = Insert(root.right, data);

            return root;
        }

        static void PrintInRangeofBST(Node root, int k1, int k2)
        {
            if (root == null) return;
            if (root.data >= k1 && root.data <= k2)
            {
                PrintInRangeofBST(root.left, k1, k2);
                Console.WriteLine(root.data + " ");
                PrintInRangeofBST(root.right, k1, k2);
            }

            else if (root.data < k1)
                PrintInRangeofBST(root.left, k1, k2);

            else PrintInRangeofBST(root.right, k1, k2);
        }
    }
}
