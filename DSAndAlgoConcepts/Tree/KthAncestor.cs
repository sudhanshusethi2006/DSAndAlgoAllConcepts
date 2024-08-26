namespace DSAndAlgoConcepts.Tree
{
    internal class KthAncestor
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
        //    var root = new Node(1);
        //    root.left = new Node(2);
        //    root.right = new Node(3);
        //    root.left.left = new Node(4);
        //    root.left.right = new Node(5);
        //    root.right.left = new Node(6);
        //    root.right.right = new Node(7);

        //    int n1 = 6;
        //    int n2 = 7;

        //    Console.WriteLine(KthAncestorOfNode(root, 4, 2));
        //    Console.WriteLine(KthAncestorOfNode(root, 4, 1));

        //}

        static int KthAncestorOfNode(Node root, int n1, int k)
        {
            if (root == null)
                return -1;
            // find the node if found return 0
            if (root.data == n1)
                return 0;
            var left = KthAncestorOfNode(root.left, n1, k);
            var right = KthAncestorOfNode(root.right, n1, k);

            if (left == -1 && right == -1)
                return -1;
            int positiveValue = Math.Max(left, right);
            if (positiveValue + 1 == k)
                Console.WriteLine(root.data);
            return positiveValue + 1;
        }
    }
}
