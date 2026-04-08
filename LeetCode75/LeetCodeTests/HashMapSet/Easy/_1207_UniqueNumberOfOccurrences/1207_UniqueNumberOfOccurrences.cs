namespace LeetCodeTests.HashMapSet.Easy._1207_UniqueNumberOfOccurrences
{
    //Given an array of integers arr, return true if the number of occurrences of each value in the array is unique, or false otherwise.
    //
    //Example 1:
    //Input: arr = [1,2,2,1,1,3]
    //Output: true
    //Explanation: The value 1 occurs 3 times, 2 occurs 2 times, 3 occurs 1 time. All occurrences are unique.
    //
    //Example 2:
    //Input: arr = [1,2]
    //Output: false
    //Explanation: 1 occurs 1 time, 2 occurs 1 time. Not all occurrences are unique.
    //
    //Constraints:
    //1 <= arr.length <= 10^4
    //-1000 <= arr[i] <= 1000

    public class Solution
    {
        public bool UniqueOccurrences(int[] arr)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().UniqueOccurrences([1, 2, 2, 1, 1, 3]);
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().UniqueOccurrences([1, 2]);
            Assert.That(result, Is.EqualTo(false));
        }
    }
}