namespace LeetCodeTests.TwoPointers.Medium._11_ContainerWithMostWater
{
    //You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).
    //
    //Find two lines that together with the x-axis form a container, such that the container contains the most water.
    //
    //Return the maximum amount of water a container can store.
    //
    //Notice that you may not slant the container.
    //
    //Example 1:
    //Input: height = [1,8,6,2,5,4,8,3,7]
    //Output: 49
    //Explanation: The max area is obtained by picking i = 1 and j = 8, with height[1] = 8 and height[8] = 7.
    //
    //Example 2:
    //Input: height = [1,1]
    //Output: 1
    //
    //Constraints:
    //n == height.length
    //2 <= n <= 10^5
    //0 <= height[i] <= 10^4

    public class Solution
    {
        public int MaxArea(int[] height)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().MaxArea([1, 8, 6, 2, 5, 4, 8, 3, 7]);
            Assert.That(result, Is.EqualTo(49));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().MaxArea([1, 1]);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Test3()
        {
            var result = new Solution().MaxArea([4, 3, 2, 1, 4]);
            Assert.That(result, Is.EqualTo(16));
        }
    }
}