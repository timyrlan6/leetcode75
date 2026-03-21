namespace LeetCodeTests.ArrayAndString.Easy._1431_KidsWithTheGreatestNumberOfCandies
{
    //There are n kids with candies.You are given an integer array candies, where each candies[i] represents the number of candies the ith kid has, and an integer extraCandies.
//Return a boolean array result of length n, where result[i] is true if, after giving the ith kid all the extraCandies, they will have the greatest number of candies among all the kids.
//
//Example 1:
//Input: candies = [2,3,5,1,3], extraCandies = 3
//Output: [true,true,true,false,true]
//
//Constraints:
//2 <= candies.length <= 100
//1 <= candies[i] <= 100
//1 <= extraCandies <= 50

    public class Solution
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().KidsWithCandies(new[] { 2, 3, 5, 1, 3 }, 3);
            Assert.That(result, Is.EqualTo(new[] { true, true, true, false, true }));
        }
    }
}