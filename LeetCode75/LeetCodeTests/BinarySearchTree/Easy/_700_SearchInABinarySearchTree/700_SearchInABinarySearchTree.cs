namespace LeetCodeTests.BinarySearchTree.Easy._700_SearchInABinarySearchTree
{
    //You are given the root of a binary search tree (BST) and an integer val.
    //
    //Find the node in the BST that the node's value equals val and return the subtree rooted with that node. If such a node does not exist, return null.
    //
    //Example 1:
    //Input: root = [4,2,7,1,3], val = 2
    //Output: [2,1,3]
    //
    //Example 2:
    //Input: root = [4,2,7,1,3], val = 5
    //Output: []
    //
    //Constraints:
    //The number of nodes in the tree is in the range [1, 5000].
    //1 <= Node.val <= 10^6
    //root is a binary search tree.
    //1 <= val <= 10^6

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
        public TreeNode SearchBST(TreeNode root, int val)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var root = new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7));
            var result = new Solution().SearchBST(root, 2);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.val, Is.EqualTo(2));
        }

        [Test]
        public void Test2()
        {
            var root = new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7));
            var result = new Solution().SearchBST(root, 5);
            Assert.That(result, Is.Null);
        }
    }
}