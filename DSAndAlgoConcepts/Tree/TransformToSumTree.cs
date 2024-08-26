namespace DSAndAlgoConcepts.Tree
{
    internal class TransformToSumTree
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

        //    Transform(root);
        //}

        static int Transform(Node root)
        {
            if (root == null) return 0;

            var leftsum = Transform(root.left);
            var rightsum = Transform(root.right);
            var data = root.data;
            root.data = leftsum + rightsum;
            return data + root.data;
        }

        static bool IsSameTree(Node p, Node q)
        {
            if ((p == null && q != null) || (p != null && q == null)) return false;
            if (p?.data != q?.data) return false;

            IsSameTree(p.left, q.left);
            IsSameTree(p.right, q.right);

            return true;
        }

    }
}
