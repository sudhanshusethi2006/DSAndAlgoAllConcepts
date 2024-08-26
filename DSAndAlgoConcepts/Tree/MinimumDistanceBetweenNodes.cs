namespace DSAndAlgoConcepts.Tree
{
    public class MinimumDistanceBetweenNodes
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

        //    int n1 = 4;
        //    int n2 = 2;

        //    Console.WriteLine(MinimumDistance(root, n1, n2));

        //}

        static int MinimumDistance(Node root, int n1, int n2)
        {
            var lca = LCA2_NoExtraSpace(root, n1, n2);
            var distance1 = LcaDistance(lca, n1);
            var distance2 = LcaDistance(lca, n2);

            return distance1 + distance2;
        }

        static int LcaDistance(Node root, int n)
        {
            if (root == null) return -1;
            if (root.data == n) return 0;
            int leftDistance = LcaDistance(root.left, n);
            int rightDistance = LcaDistance(root.right, n);

            if (leftDistance == -1 && rightDistance == -1) return -1;
            if (leftDistance == -1) return rightDistance + 1;
            else return leftDistance + 1;
        }


        static Node LCA2_NoExtraSpace(Node root, int n1, int n2)
        {
            if (root == null || root.data == n1 || root.data == n2)
                return root;

            var leftLCA = LCA2_NoExtraSpace(root.left, n1, n2);
            var rightLCA = LCA2_NoExtraSpace(root.right, n1, n2);

            if (leftLCA == null)
                return rightLCA;
            if (rightLCA == null)
                return leftLCA;


            return root;
        }


    }
}
