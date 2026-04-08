namespace LeetCodeTests.BinaryTree.Easy._104_MaximumDepthOfBinaryTree
{
    //Given the root of a binary tree, return its maximum depth.
    //
    //A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
    //
    //Example 1:
    //Input: root = [3,9,20,null,null,15,7]
    //Output: 3
    //
    //Example 2:
    //Input: root = [1,null,2]
    //Output: 2
    //
    //Constraints:
    //The number of nodes in the tree is in the range [0, 10^4].
    //-100 <= Node.val <= 100

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
        public int MaxDepth(TreeNode root)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var root = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
            var result = new Solution().MaxDepth(root);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Test2()
        {
            var root = new TreeNode(1, null, new TreeNode(2));
            var result = new Solution().MaxDepth(root);
            Assert.That(result, Is.EqualTo(2));
        }
    }
}