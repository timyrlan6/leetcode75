namespace LeetCodeTests.BinaryTree.Medium._1372_LongestZigzagPathInABinaryTree
{
    //You are given the root of a binary tree.
    //
    //A ZigZag path for a binary tree is defined as follow:
    //- Choose any node in the tree and a direction (right or left).
    //- If the current direction is right, move to the right child of the current node; otherwise, move to the left child.
    //- Change the direction from right to left or left to right.
    //- Repeat step 2 until you can no longer move.
    //
    //The path starts at the root node, moves through tree edges, and ends at any node. The length of a path is the number of edges traversed.
    //
    //Return the length of the longest ZigZag path in the tree.
    //
    //Example 1:
    //Input: root = [1,null,1,1,1,null,null,1,1,null,1]
    //Output: 4
    //Explanation: Longest ZigZag: 1->1 (right)->1 (left)->1 (right) = 4 edges.
    //
    //Example 2:
    //Input: root = [1,1,1,null,1,null,null,1,1,null,1]
    //Output: 3
    //
    //Constraints:
    //The number of nodes in the tree is in the range [1, 10^4].
    //1 <= Node.val <= 100

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
        public int LongestZigZag(TreeNode root)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var root = new TreeNode(1, null, new TreeNode(1, new TreeNode(1, new TreeNode(1), new TreeNode(1)), new TreeNode(1)));
            var result = new Solution().LongestZigZag(root);
            Assert.That(result, Is.EqualTo(4));
        }
    }
}