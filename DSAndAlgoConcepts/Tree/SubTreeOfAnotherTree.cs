using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.Tree
{
    internal class SubTreeOfAnotherTree
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

        static bool isSubtree(Node tree, Node subTree)
        {
            if (tree == null) return false;

            if (tree.data == subTree.data)
            {
                return isIdentical(tree, subTree);
            }
            return isSubtree(tree.left, subTree) || isSubtree(tree.right, subTree);

        }

        private static bool isIdentical(Node tree, Node subTree)
        {
            if (tree == null && subTree == null) return true;
            if (tree == null || subTree == null || (tree.data != subTree.data)) return false;

            return isIdentical(tree.left, subTree.left) && isIdentical(tree.right, subTree.right);
        }
        //    static void Main(string[] args)
        //    {

        //        var root = new Node(1);
        //        root.left = new Node(2);
        //        root.right = new Node(3);
        //        root.left.left = new Node(4);
        //        root.left.right = new Node(5);
        //        root.right.left = new Node(6);
        //        root.right.right = new Node(7);

        //        var subtree = new Node(2);
        //        subtree.left = new Node(4);
        //        subtree.right = new Node(5);
        //        //subtree.right.left = new Node(10);

        //        var ans = isSubtree(root, subtree);
        //    }
    }
}
