namespace LeetCodeTests.DP.Easy._1137_NthTribonacciNumber
{
    //The Tribonacci sequence Tn is defined as:
    //T0 = 0, T1 = 1, T2 = 1, and Tn = Tn-1 + Tn-2 + Tn-3 for n >= 0.
    //
    //Given n, return the value of Tn.
    //
    //Example 1:
    //Input: n = 4
    //Output: 4
    //Explanation: T_3 = T_2 + T_1 + T_0 = 1 + 1 + 0 = 2, T_4 = T_3 + T_2 + T_1 = 2 + 1 + 1 = 4.
    //
    //Example 2:
    //Input: n = 25
    //Output: 1389537
    //
    //Constraints:
    //0 <= n <= 37
    //The answer is guaranteed to fit within a 32-bit integer.

    public class Solution
    {
        public int Tribonacci(int n)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().Tribonacci(4);
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().Tribonacci(25);
            Assert.That(result, Is.EqualTo(1389537));
        }
    }
}