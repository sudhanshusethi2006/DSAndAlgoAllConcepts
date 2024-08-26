using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.Tree
{
    // number of nodes in the longest path between any 2 leaves

    // 2 cases
    // Diamater passes through root
    // diamater doesnt passes through root

    internal class DiameterOfTree
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

        static int GetDiamter(Node node) //O(N^2)
        {
            if (node == null) return 0;

            int leftDiam = GetDiamter(node.left);
            int leftHeigt = GetHeight(node.left);
            int rightDiam = GetDiamter(node.right);
            int rightHeight = GetHeight(node.right);

            int selfDiam = leftHeigt + rightHeight + 1;

            return Math.Max(selfDiam, Math.Max(leftDiam, rightDiam));
        }

        // optimized 

        static Information GetDiamter_Otpmtimized(Node node)
        {
            if (node == null) return new Information(0, 0);
            var leftInformation = GetDiamter_Otpmtimized(node.left);
            var rightInfromation = GetDiamter_Otpmtimized(node.right);
            int diameter = Math.Max(Math.Max(leftInformation.diameter, rightInfromation.diameter), leftInformation.height + rightInfromation.height + 1);
            int height = Math.Max(leftInformation.height, rightInfromation.height) + 1;
            return new Information(height, diameter);
        }

        class Information
        {
            public int diameter;
            public int height;
            public Information(int height, int diameter)
            {
                this.diameter = diameter;
                this.height = height;
            }
        }

        //static void Main(string[] args)
        //{
        //    int[] nodes = { 1, 2, 4, -1, -1, 5, -1, -1, 3, -1, 6, -1, -1 };
        //    BinaryTree binaryTree = new BinaryTree();
        //    var tree = binaryTree.BuildTree(nodes);
        //    var diamter = GetDiamter_Otpmtimized(tree);
        //}
    }


}
