namespace LeetCodeTests.BitManipulation.Easy._338_CountingBits
{
    //Given an integer n, return an array ans of length n + 1 such that for each i (0 <= i <= n), ans[i] is the number of 1's in the binary representation of i.
    //
    //Example 1:
    //Input: n = 2
    //Output: [0,1,1]
    //Explanation: 0 -> 0, 1 -> 1, 2 -> 10 has 1 bit.
    //
    //Example 2:
    //Input: n = 5
    //Output: [0,1,1,2,1,2]
    //
    //Constraints:
    //0 <= n <= 10^5

    public class Solution
    {
        public int[] CountBits(int n)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().CountBits(2);
            Assert.That(result, Is.EquivalentTo(new[] { 0, 1, 1 }));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().CountBits(5);
            Assert.That(result, Is.EquivalentTo(new[] { 0, 1, 1, 2, 1, 2 }));
        }
    }
}