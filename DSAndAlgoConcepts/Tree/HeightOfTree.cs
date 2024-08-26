using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.Tree
{
    internal class HeightOfTree
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

        static int GetHeight(Node node)
        {
            if (node == null) return 0;
            var left = GetHeight(node.left);
            var right = GetHeight(node.right);
            return Math.Max(left, right) + 1;
        }

        //static void Main(string[] args)
        //{
        //    int[] nodes = { 1, 2, 4, -1, -1, 5, -1, -1, 3, -1, 6, -1, -1 };
        //    BinaryTree binaryTree = new BinaryTree();
        //    var tree = binaryTree.BuildTree(nodes);

        //}
    }
}
