namespace LeetCodeTests.BinarySearchTree.Medium._450_DeleteNodeInABST
{
    //Given a root node reference of a BST and a key, delete the node with the given key in the BST. Return the root node reference (may be changed).
    //
    //Example 1:
    //Input: root = [5,3,6,2,4,null,7], key = 3
    //Output: [5,4,6,2,null,null,7]
    //
    //Example 2:
    //Input: root = [5,3,6,2,4,null,7], key = 0
    //Output: [5,3,6,2,4,null,7]
    //
    //Constraints:
    //The number of nodes in the tree is in the range [0, 10^4].
    //-10^5 <= Node.val <= 10^5
    //root is a valid BST.
    //-10^5 <= key <= 10^5

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
        public TreeNode DeleteNode(TreeNode root, int key)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var root = new TreeNode(5, new TreeNode(3, new TreeNode(2), new TreeNode(4)), new TreeNode(6, null, new TreeNode(7)));
            var result = new Solution().DeleteNode(root, 3);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.val, Is.EqualTo(5));
        }
    }
}