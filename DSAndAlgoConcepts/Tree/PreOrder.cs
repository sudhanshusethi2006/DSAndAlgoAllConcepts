using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.Tree
{
    class PreOrder
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

        static void PreOrderTraversal(Node tree)
        {
            if (tree == null) return;
            Console.Write(tree.data + " , ");
            PreOrderTraversal(tree.left);
            PreOrderTraversal(tree.right);
        }

        //public static void Main(string[] args)
        //{
        //    int[] nodes = { 1, 2, 4, -1, -1, 5, -1, -1, 3, -1, 6, -1, -1 };
        //    BinaryTree binaryTree = new BinaryTree();
        //    var tree = binaryTree.BuildTree(nodes);

        //    PreOrderTraversal(tree);
        //}
    }
}
