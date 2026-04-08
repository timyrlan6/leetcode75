namespace LeetCodeTests.BinaryTree.Medium._1161_MaximumLevelSumOfABinaryTree
{
    //Given the root of a binary tree, return the level with the maximum sum of node values.
    //
    //Example 1:
    //Input: root = [1,7,0,7,-8,null,null,null,null,-7,null,-7]
    //Output: 2
    //Explanation: Level 2 has nodes 7, 0 with sum = 14.
    //
    //Example 2:
    //Input: root = [989,null,10250,null,null,98693,null,-89388,null,null,null,-32127]
    //Output: 2
    //
    //Constraints:
    //The number of nodes in the tree is in the range [1, 10^4].
    //-10^5 <= Node.val <= 10^5

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
        public int MaxLevelSum(TreeNode root)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var root = new TreeNode(1, new TreeNode(7, new TreeNode(7), new TreeNode(-8)), new TreeNode(0));
            var result = new Solution().MaxLevelSum(root);
            Assert.That(result, Is.EqualTo(2));
        }
    }
}