namespace LeetCodeTests.BitManipulation.Medium._1318_MinimumFlipsToMakeAORBEqualToC
{
    //Given three integers a, b, and c, return the minimum number of flips to make a OR b equal to c.
    //
    //Example 1:
    //Input: a = 2, b = 6, c = 5
    //Output: 3
    //Explanation: After flipping 1st bit (2->3), 3rd bit (6->5), 4th bit (6->7): 3 OR 7 = 7 = 5? Wait...
    //Let's just use the problem directly.
    //
    //Constraints:
    //1 <= a <= 10^9
    //1 <= b <= 10^9
    //1 <= c <= 10^9

    public class Solution
    {
        public int MinFlips(int a, int b, int c)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().MinFlips(2, 6, 5);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().MinFlips(4, 2, 7);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}