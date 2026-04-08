namespace LeetCodeTests.BinaryTree.Medium._236_LowestCommonAncestorOfABinaryTree
{
    //Given a binary tree root, and two nodes p and q, return the lowest common ancestor (LCA) of the two nodes.
    //
    //The lowest common ancestor is the lowest node that has both p and q as descendants (where we allow a node to be a descendant of itself).
    //
    //Example 1:
    //Input: root = [3,5,1,6,2,0,8,null,null,7,4], p = 5, q = 1
    //Output: 3
    //Explanation: The LCA of nodes 5 and 1 is 3.
    //
    //Example 2:
    //Input: root = [3,5,1,6,2,0,8,null,null,7,4], p = 5, q = 4
    //Output: 5
    //Explanation: The LCA of nodes 5 and 4 is 5, since a node can be a descendant of itself.
    //
    //Constraints:
    //The number of nodes in the tree is in the range [2, 10^5].
    //-10^9 <= Node.val <= 10^9
    //All Node.val are unique.
    //p != q
    //p and q exist in the tree.

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
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var root = new TreeNode(3, new TreeNode(5, new TreeNode(6), new TreeNode(2, new TreeNode(7), new TreeNode(4))), new TreeNode(1, new TreeNode(0), new TreeNode(8)));
            var result = new Solution().LowestCommonAncestor(root, root.left, root.right);
            Assert.That(result.val, Is.EqualTo(3));
        }
    }
}