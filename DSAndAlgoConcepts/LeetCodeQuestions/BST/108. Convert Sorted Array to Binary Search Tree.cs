namespace DSAndAlgoConcepts.LeetCodeQuestions.BST
{
    internal class ConvertSortedArraytoBinarySearchTree
    {
        //static void Main(string[] args)
        //{
        //    int[] nums = { -10, -3, 0, 5, 9 };

        //    Solution obj = new Solution();

        //    var tree = obj.SortedArrayToBST(nums);

        //}
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public class Solution
        {

            public TreeNode SortedArrayToBST(int[] nums)
            {
                var root = GenerateTree(nums, 0, nums.Length - 1);
                return root;
            }

            private TreeNode GenerateTree(int[] nums, int start, int end)
            {
                if (start > end) return null;

                int mid = (start + end) / 2;

                TreeNode root = new TreeNode(nums[mid]);

                root.left = GenerateTree(nums, start, mid - 1);

                root.right = GenerateTree(nums, mid + 1, end);


                return root;
            }
        }
    }
}
