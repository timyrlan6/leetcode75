namespace LeetCodeTests.BinaryTree.Easy._872_LeafSimilarTrees
{
    //Consider two trees with root nodes root1 and root2.
    //
    //A leaf is a node with no children. Two trees are leaf-similar if their leaf sequence is the same.
    //
    //Return true if there exists two roots root1 and root2 such that the leaf sequence of tree root1 equals the leaf sequence of tree root2. Otherwise, return false.
    //
    //Example 1:
    //Input: root1 = [3,5,1,6,2,9,8,null,null,7,4], root2 = [3,5,1,6,7,4]
    //Output: true
    //Explanation: Both trees have leaf sequence [6,7,4].
    //
    //Example 2:
    //Input: root1 = [1,2,3], root2 = [1,3,2]
    //Output: false
    //
    //Constraints:
    //The number of nodes in each tree is in the range [1, 200].
    //Both trees consist of integers in the range [1, 200].

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
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var root1 = new TreeNode(3, new TreeNode(5, new TreeNode(6), new TreeNode(2, new TreeNode(7), new TreeNode(4))), new TreeNode(1, new TreeNode(9), new TreeNode(8)));
            var root2 = new TreeNode(3, new TreeNode(5, new TreeNode(6), new TreeNode(7)), new TreeNode(4));
            var result = new Solution().LeafSimilar(root1, root2);
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void Test2()
        {
            var root1 = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            var root2 = new TreeNode(1, new TreeNode(3), new TreeNode(2));
            var result = new Solution().LeafSimilar(root1, root2);
            Assert.That(result, Is.EqualTo(false));
        }
    }
}