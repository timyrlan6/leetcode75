namespace LeetCodeTests.Stack.Medium._735_AsteroidCollision
{
    //We are given an array asteroids of integers representing asteroids in a row.
    //
    //For each asteroid, the absolute value represents its size, and the sign represents its direction (positive meaning right, negative meaning left). Each asteroid moves at the same speed.
    //
    //Find out the state of the asteroids after all collisions.
    //
    //If two asteroids meet, the smaller one explodes. If both are the same size, both explode.
    //
    //Two asteroids moving in the same direction will never meet.
    //
    //Example 1:
    //Input: asteroids = [5,10,-5]
    //Output: [5,10]
    //Explanation: The 10 and -5 meet, -5 explodes. Result: [5,10].
    //
    //Example 2:
    //Input: asteroids = [8,-8]
    //Output: []
    //Explanation: They meet and explode. Result: [].
    //
    //Constraints:
    //2 <= asteroids.length <= 10^4
    //-1000 <= asteroids[i] <= 1000
    //asteroids[i] != 0

    public class Solution
    {
        public int[] AsteroidCollision(int[] asteroids)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().AsteroidCollision([5, 10, -5]);
            Assert.That(result, Is.EquivalentTo(new[] { 5, 10 }));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().AsteroidCollision([8, -8]);
            Assert.That(result, Is.Empty);
        }
    }
}