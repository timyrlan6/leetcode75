namespace LeetCodeTests.Graphs.Medium._841_KeysAndRooms
{
    //There are n rooms labeled from 0 to n - 1 and all rooms are locked except room 0. 
    //
    //You are given an array rooms where rooms[i] contains a list of keys that you can acquire to unlock other rooms.
    //
    //For example, if rooms[i] = [1,3], it means you can acquire keys 1 and 3 to unlock rooms 1 and 3.
    //
    //Initially, you are in room 0 only. Return true if you can visit all rooms, or false otherwise.
    //
    //Example 1:
    //Input: rooms = [[1],[2],[3],[]]
    //Output: true
    //Explanation: Visit rooms: 0 -> 1 -> 2 -> 3.
    //
    //Example 2:
    //Input: rooms = [[1,3],[3,0,1],[2],[0]]
    //Output: false
    //Explanation: You cannot visit room 2.
    //
    //Constraints:
    //n == rooms.length
    //1 <= n <= 1000
    //0 <= rooms[i].length <= 1000
    //1 <= rooms[i][j] <= n - 1
    //All values in rooms[i] are unique.

    public class Solution
    {
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().CanVisitAllRooms(new[] { new[] { 1 }, new[] { 2 }, new[] { 3 }, new int[] { } });
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().CanVisitAllRooms(new[] { new[] { 1, 3 }, new[] { 3, 0, 1 }, new[] { 2 }, new[] { 0 } });
            Assert.That(result, Is.EqualTo(false));
        }
    }
}