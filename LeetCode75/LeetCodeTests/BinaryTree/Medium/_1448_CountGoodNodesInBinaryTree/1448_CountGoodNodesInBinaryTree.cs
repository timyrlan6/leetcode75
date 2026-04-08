namespace LeetCodeTests.BinaryTree.Medium._1448_CountGoodNodesInBinaryTree
{
    //Given the root of a binary tree, a node is good if it is greater than or equal to all values on the unique path from the root to that node.
    //
    //Return the number of good nodes in the binary tree.
    //
    //Example 1:
    //Input: root = [3,1,4,3,null,1,5]
    //Output: 4
    //Explanation: Nodes 3, 4, 5 are good. Node 3 is not good because there exists a node with value 1 on the path from 3 to 1.
    //
    //Example 2:
    //Input: root = [3,3,null,4,2]
    //Output: 3
    //Explanation: Nodes 3, 2, 3 are good.
    //
    //Constraints:
    //The number of nodes in the binary tree is in the range [1, 10^5].
    //Each node's value is between [-10^4, 10^4].

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
        public int GoodNodes(TreeNode root)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var root = new TreeNode(3, new TreeNode(1, new TreeNode(3)), new TreeNode(4, new TreeNode(1), new TreeNode(5)));
            var result = new Solution().GoodNodes(root);
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Test2()
        {
            var root = new TreeNode(3, new TreeNode(3, new TreeNode(4), new TreeNode(2)), null);
            var result = new Solution().GoodNodes(root);
            Assert.That(result, Is.EqualTo(3));
        }
    }
}