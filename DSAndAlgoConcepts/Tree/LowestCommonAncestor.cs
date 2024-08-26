namespace DSAndAlgoConcepts.Tree
{
    internal class LowestCommonAncestor
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

        //    var lca = LCA(root, n1, n2);
        //    var lca2 = LCA2_NoExtraSpace(root, n1, n2);
        //}

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

        static Node LCA(Node root, int n1, int n2)
        {
            var path1 = new List<Node>();
            var path2 = new List<Node>();

            getPath(root, n1, path1);
            getPath(root, n2, path2);


            //last common ancestor
            int i = 0;
            for (; i < path1.Count && i < path2.Count; i++)
            {
                if (path1[i] != path2[i])
                    break;

            }

            var lca = path1[i - 1];
            return lca;
        }

        static bool getPath(Node node, int n, List<Node> path)
        {
            if (node == null)
                return false;

            path.Add(node);

            if (node.data == n)
                return true;

            var foundLeft = getPath(node.left, n, path);
            var foundRight = getPath(node.right, n, path);

            if (foundLeft || foundRight)
                return true;

            path.Remove(path.Last());

            return false;
        }









    }
}
