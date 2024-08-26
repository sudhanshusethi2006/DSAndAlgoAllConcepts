namespace DSAndAlgoConcepts.BinarySearchTree
{
    internal class BST
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
        //    int[] values = { 8, 5, 10, 3, 6, 1, 4, 10, 11, 14 };
        //    Node root = null;

        //    for (int i = 0; i < values.Length; i++)
        //    {
        //        root = Insert(root, values[i]);
        //    }

        //    Inorder(root);

        //    root = Delete(root, 5);
        //    Console.WriteLine();
        //    Inorder(root);
        //}

        static void Inorder(Node root)
        {
            if (root == null)
                return;

            Inorder(root.left);
            Console.Write(root.data + " ");
            Inorder(root.right);

        }

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

        static bool Search(Node root, int item)
        {
            if (root == null) return false;
            if (root.data == item)
                return true;

            if (item > root.data)
                return Search(root.right, item);
            else
                return Search(root.left, item);

        }


        static Node Delete(Node root, int item)
        {
            // leaf node 
            if (root.data == item)
            {
                if (root.left == null && root.right == null)
                    return null;

                if (root.left == null)
                    return root.right;
                else if (root.right == null)
                    return root.left;

                // if both left and right child are not null;
                var InorderSuccessor = GetInorderSuccessor(root.right);

                root.data = InorderSuccessor.data;

                root.right = Delete(root.right, InorderSuccessor.data);

            }
            else
            {
                if (root.data < item)
                    root.right = Delete(root.right, item);
                else
                    root.left = Delete(root.left, item);
            }

            return root;

        }

        private static Node GetInorderSuccessor(Node current)
        {
            while (current.left != null)
            {
                current = current.left;
            }
            return current;
        }


    }

}
