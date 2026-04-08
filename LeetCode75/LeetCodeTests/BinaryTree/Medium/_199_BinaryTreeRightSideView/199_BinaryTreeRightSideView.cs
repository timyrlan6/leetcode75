namespace LeetCodeTests.BinaryTree.Medium._199_BinaryTreeRightSideView
{
    //Given the root of a binary tree, imagine yourself standing on the right side of it, return the values of the nodes you can see ordered from top to bottom.
    //
    //Example 1:
    //Input: root = [1,2,3,null,5,null,4]
    //Output: [1,3,4]
    //
    //Example 2:
    //Input: root = [1,null,3]
    //Output: [1,3]
    //
    //Constraints:
    //The number of nodes in the tree is in the range [0, 100].
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
        public IList<int> RightSideView(TreeNode root)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var root = new TreeNode(1, new TreeNode(2, null, new TreeNode(5)), new TreeNode(3, null, new TreeNode(4)));
            var result = new Solution().RightSideView(root);
            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 4 }));
        }
    }
}