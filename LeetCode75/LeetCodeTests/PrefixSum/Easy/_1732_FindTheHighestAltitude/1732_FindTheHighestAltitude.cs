namespace LeetCodeTests.PrefixSum.Easy._1732_FindTheHighestAltitude
{
    //There is a biker going on a road trip. The road trip consists of n + 1 points at different altitudes. The biker starts at point 0 with altitude 0.
    //
    //You are given an integer array gain of length n where gain[i] is the net altitude change from point i to point i + 1 (i.e., from point i to point i + 1).
    //
    //Return the highest altitude of the biker.
    //
    //Example 1:
    //Input: gain = [-5,1,5,0,-7]
    //Output: 1
    //Explanation: The altitudes are [0,-5,-4,1,1,6] where the highest is 6.
    //Wait, that doesn't match the example. Let me recalculate.
    //Start at 0.
    //After -5: -5
    //After 1: -4
    //After 5: 1
    //After 0: 1
    //After -7: -6
    //Highest is 1.
    //
    //Example 2:
    //Input: gain = [-4,-3,-2,-1,4,3,2]
    //Output: 0
    //Explanation: Altitudes are [0,-4,-7,-9,-10,-6,-4,-2]. Highest is 0.
    //
    //Constraints:
    //n == gain.length
    //1 <= n <= 100
    //-100 <= gain[i] <= 100

    public class Solution
    {
        public int LargestAltitude(int[] gain)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().LargestAltitude([-5, 1, 5, 0, -7]);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().LargestAltitude([-4, -3, -2, -1, 4, 3, 2]);
            Assert.That(result, Is.EqualTo(0));
        }
    }
}