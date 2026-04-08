namespace LeetCodeTests.BinaryTree.Medium._437_PathSumIII
{
    //Given the root of a binary tree and an integer targetSum, return the number of paths where the sum of the values along the path equals targetSum.
    //
    //The path does not need to start or end at the root or leaf, but it must go downwards (i.e., from parent nodes to child nodes).
    //
    //Example 1:
    //Input: root = [10,5,-3,3,2,null,11,3,-2,null,1], targetSum = 8
    //Output: 3
    //Explanation: The paths that sum to 8 are: 5 -> 3, 5 -> 2 -> 1, -3 -> 11.
    //
    //Example 2:
    //Input: root = [5,4,8,11,null,13,4,7,2,null,null,5,1], targetSum = 22
    //Output: 3
    //
    //Constraints:
    //The number of nodes in the tree is in the range [0, 1000].
    //-10^9 <= targetSum <= 10^9

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
        public int PathSum(TreeNode root, int targetSum)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var root = new TreeNode(10, new TreeNode(5, new TreeNode(3, new TreeNode(3), new TreeNode(-2)), new TreeNode(2, null, new TreeNode(1))), new TreeNode(-3, null, new TreeNode(11)));
            var result = new Solution().PathSum(root, 8);
            Assert.That(result, Is.EqualTo(3));
        }
    }
}