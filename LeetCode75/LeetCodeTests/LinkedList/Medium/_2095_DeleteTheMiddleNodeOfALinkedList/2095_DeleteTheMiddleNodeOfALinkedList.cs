namespace LeetCodeTests.LinkedList.Medium._2095_DeleteTheMiddleNodeOfALinkedList
{
    //Given the head of a singly linked list, delete the middle node, and return the head of the modified linked list.
    //
    //If there are two middle nodes, delete the second middle node.
    //
    //Example 1:
    //Input: head = [1,3,4,7,1,2,6]
    //Output: [1,3,4,1,2,6]
    //Explanation: The linked list is 1 -> 3 -> 4 -> 7 -> 1 -> 2 -> 6.
    //The middle node is 7, delete it.
    //
    //Example 2:
    //Input: head = [1,2,3,4]
    //Output: [1,2,4]
    //Explanation: The linked list is 1 -> 2 -> 3 -> 4.
    //The middle node is 3, delete it.
    //
    //Constraints:
    //The number of nodes in the list is in the range [1, 10^5].
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
        public ListNode DeleteMiddle(ListNode head)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var head = new ListNode(1, new ListNode(3, new ListNode(4, new ListNode(7, new ListNode(1, new ListNode(2, new ListNode(6)))))));
            var result = new Solution().DeleteMiddle(head);
            var values = new List<int>();
            while (result != null)
            {
                values.Add(result.val);
                result = result.next;
            }
            Assert.That(values, Is.EquivalentTo(new[] { 1, 3, 4, 1, 2, 6 }));
        }

        [Test]
        public void Test2()
        {
            var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
            var result = new Solution().DeleteMiddle(head);
            var values = new List<int>();
            while (result != null)
            {
                values.Add(result.val);
                result = result.next;
            }
            Assert.That(values, Is.EquivalentTo(new[] { 1, 2, 4 }));
        }
    }
}