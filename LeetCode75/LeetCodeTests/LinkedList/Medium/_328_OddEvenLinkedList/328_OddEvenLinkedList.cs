namespace LeetCodeTests.LinkedList.Medium._328_OddEvenLinkedList
{
    //Given the head of a singly linked list, group all the nodes with odd indices together followed by the even indices, and return the reordered list.
    //
    //Example 1:
    //Input: head = [1,2,3,4,5]
    //Output: [1,3,5,2,4]
    //
    //Example 2:
    //Input: head = [2,1,3,5,6,4,7]
    //Output: [2,3,6,7,1,5,4]
    //
    //Constraints:
    //The number of nodes in the linked list is in the range [0, 10^4].
    //-10^6 <= Node.val <= 10^6

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
        public ListNode OddEvenList(ListNode head)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            var result = new Solution().OddEvenList(head);
            var values = new List<int>();
            while (result != null)
            {
                values.Add(result.val);
                result = result.next;
            }
            Assert.That(values, Is.EquivalentTo(new[] { 1, 3, 5, 2, 4 }));
        }
    }
}