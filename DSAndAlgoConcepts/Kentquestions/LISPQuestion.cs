using System.Text;

namespace DSAndAlgoConcepts.Kentquestions
{
    internal class LISPQuestion
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

        class BinaryTree
        {
            public int idx;

            public Node BuildTree(string Nodes)
            {
                idx++;

                while (idx < Nodes.Length && (Nodes[idx] == '(' || Nodes[idx] == ' ' || Nodes[idx] == '\r' || Nodes[idx] == '\n' || Nodes[idx] == '\n' || Nodes[idx] == ')'))
                {
                    if (idx < Nodes.Length - 1 && Nodes[idx] == '(' && Nodes[idx + 1] == ')')
                    {
                        idx = idx + 1;
                        return null;
                    }
                    idx++;
                }

                StringBuilder stringBuilder = new StringBuilder();
                while (idx < Nodes.Length && Nodes[idx] != '(' && Nodes[idx] != ')' && Nodes[idx] != ' ' && Nodes[idx] != '\r' && Nodes[idx] != '\n')
                {
                    stringBuilder.Append(Nodes[idx]);
                    idx++;
                }

                var newNode = new Node(int.Parse(stringBuilder.ToString()));
                newNode.left = BuildTree(Nodes);
                newNode.right = BuildTree(Nodes);
                return newNode;
            }

            public bool PreOrderTraversal(Node tree, int target, int count)
            {
                if (tree == null)
                {
                    if (count == target) return true;
                    return false;
                }
                count += tree.data;

                var left = PreOrderTraversal(tree.left, target, count);
                if (left)
                    return true;
                var right = PreOrderTraversal(tree.right, target, count);
                if (right) return true;
                return false;

            }
        }



        static int idx;
        //static int count = 0;
        static int target;
        public static bool tree(string Nodes, int count)
        {
            idx++;

            while (idx < Nodes.Length && (Nodes[idx] == '(' || Nodes[idx] == ' ' || Nodes[idx] == '\r' || Nodes[idx] == '\n' || Nodes[idx] == '\n' || Nodes[idx] == ')'))
            {
                if (idx < Nodes.Length - 1 && Nodes[idx] == '(' && Nodes[idx + 1] == ')')
                {
                    if (count == target)
                        return true;
                    idx = idx + 1;
                    return false;
                }
                idx++;
            }

            StringBuilder stringBuilder = new StringBuilder();
            while (idx < Nodes.Length && Nodes[idx] != '(' && Nodes[idx] != ')' && Nodes[idx] != ' ' && Nodes[idx] != '\r' && Nodes[idx] != '\n')
            {
                stringBuilder.Append(Nodes[idx]);
                idx++;
            }
            count += int.Parse(stringBuilder.ToString());

            var left = tree(Nodes, count);

            var right = tree(Nodes, count);


            return left || right;
        }

        // public static void Main(string[] args)
        // {
        //     bool? test = null;
        //     var x = test.HasValue;
        //     if (test.HasValue || test.Value == true)
        //     {
        //         Console.WriteLine("yes");
        //     }

        //     BinaryTree binaryTree = new BinaryTree();


        //     List<string> inputs = new List<string>() {
        //     "22 (5 (4 (11 (7 () ()) (2 () ()) ) ()) (8 (13 () ()) (4 () (1 () ()) ) ) )",
        //     "20 (5 (4 (11 (7 () ()) (2 () ()) ) ()) (8 (13 () ()) (4 () (1 () ()) ) ) )",
        //     "10 (3\r\n(2 (4 () () )\r\n(8 () () ) )\r\n(1 (6 () () )\r\n(4 () () ) ) )",
        //     "5 ()"
        //};

        //     foreach (string input in inputs)
        //     {
        //         binaryTree.idx = -1;
        //         int index = input.IndexOf(' ', 0);
        //         target = int.Parse(input.Substring(0, index));
        //         var tree = binaryTree.BuildTree(input.Substring(index + 1));
        //         Console.WriteLine(binaryTree.PreOrderTraversal(tree, target, 0) == true ? "yes" : "no");

        //     }


        //     //without tree
        //     foreach (string input in inputs)
        //     {
        //         idx = -1;
        //         int index = input.IndexOf(' ', 0);
        //         target = int.Parse(input.Substring(0, index));
        //         Console.WriteLine(tree(input.Substring(index + 1), 0) == true ? "yes" : "no");

        //     }
        // }
    }
}
