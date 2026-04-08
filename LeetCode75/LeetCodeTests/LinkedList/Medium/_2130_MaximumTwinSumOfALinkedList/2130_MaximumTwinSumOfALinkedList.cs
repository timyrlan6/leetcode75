namespace LeetCodeTests.LinkedList.Medium._2130_MaximumTwinSumOfALinkedList
{
    //In a linked list of size n, where n is even, the ith node (0-indexed) of the linked list is known as the twin of the (n-1-i)th node, if 0 <= i < n / 2.
    //
    //The twin sum of a node is the sum of the values of the node and its twin.
    //
    //Given the head of a linked list with even length, return the maximum twin sum of the linked list.
    //
    //Example 1:
    //Input: head = [5,4,2,1]
    //Output: 6
    //Explanation: Node 0 is twin of node 3, twin sum = 5 + 1 = 6. Node 1 is twin of node 2, twin sum = 4 + 2 = 6. Max = 6.
    //
    //Example 2:
    //Input: head = [4,2,2,3]
    //Output: 7
    //Explanation: Node 0 twin 3: 4 + 3 = 7. Node 1 twin 2: 2 + 2 = 4. Max = 7.
    //
    //Constraints:
    //The number of nodes in the list is an even integer in the range [2, 10^5].
    //1 <= Node.val <= 10^5

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public int PairSum(ListNode head)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var head = new ListNode(5, new ListNode(4, new ListNode(2, new ListNode(1))));
            var result = new Solution().PairSum(head);
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void Test2()
        {
            var head = new ListNode(4, new ListNode(2, new ListNode(2, new ListNode(3))));
            var result = new Solution().PairSum(head);
            Assert.That(result, Is.EqualTo(7));
        }
    }
}