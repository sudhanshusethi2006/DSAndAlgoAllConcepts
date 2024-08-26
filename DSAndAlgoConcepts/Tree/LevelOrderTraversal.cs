using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.Tree
{
    internal class LevelOrderTraversal
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
            private int idx = -1;
            public Node BuildTree(int[] Nodes)
            {
                idx++;
                if (Nodes[idx] == -1) return null;
                var newNode = new Node(Nodes[idx]);
                newNode.left = BuildTree(Nodes);
                newNode.right = BuildTree(Nodes);
                return newNode;

            }
        }

        static void LevelOrderTreeTraversal(Node tree)
        {
            Queue<Node> queue = new Queue<Node>();

            queue.Enqueue(tree);
            queue.Enqueue(null);
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                if (node == null)
                {
                    Console.WriteLine();
                    if (queue.Count == 0)
                        break;
                    else
                        queue.Enqueue(null);
                }
                else
                {
                    Console.Write(node.data);
                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }
            }
        }
        //static void Main(string[] args)
        //{
        //    int[] nodes = { 1, 2, 4, -1, -1, 5, -1, -1, 3, -1, 6, -1, -1 };
        //    BinaryTree binaryTree = new BinaryTree();
        //    var tree = binaryTree.BuildTree(nodes);

        //    LevelOrderTreeTraversal(tree);
        //}
    }
}
