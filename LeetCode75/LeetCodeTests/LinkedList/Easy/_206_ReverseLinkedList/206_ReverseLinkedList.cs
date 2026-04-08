namespace LeetCodeTests.LinkedList.Easy._206_ReverseLinkedList
{
    //Given the head of a singly linked list, reverse the list, and return the reversed list.
    //
    //Example 1:
    //Input: head = [1,2,3,4,5]
    //Output: [5,4,3,2,1]
    //
    //Example 2:
    //Input: head = [1,2]
    //Output: [2,1]
    //
    //Constraints:
    //The number of nodes in the list is in the range [0, 5000].
    //-5000 <= Node.val <= 5000

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
        public ListNode ReverseList(ListNode head)
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
            var result = new Solution().ReverseList(head);
            var values = new List<int>();
            while (result != null)
            {
                values.Add(result.val);
                result = result.next;
            }
            Assert.That(values, Is.EquivalentTo(new[] { 5, 4, 3, 2, 1 }));
        }

        [Test]
        public void Test2()
        {
            var head = new ListNode(1, new ListNode(2));
            var result = new Solution().ReverseList(head);
            var values = new List<int>();
            while (result != null)
            {
                values.Add(result.val);
                result = result.next;
            }
            Assert.That(values, Is.EquivalentTo(new[] { 2, 1 }));
        }
    }
}