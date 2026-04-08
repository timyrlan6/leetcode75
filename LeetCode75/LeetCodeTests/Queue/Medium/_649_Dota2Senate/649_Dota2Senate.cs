namespace LeetCodeTests.Queue.Medium._649_Dota2Senate
{
    //There are two senator groups: Radiant and Dire.
    //
    //Each senate is a string of characters, where each character represents a senator. The character can be either 'R' (Radiant) or 'D' (Dire).
    //
    //A senator can ban another senator. When a senator is banned, all the senators from his group after him (to the right) are removed from the game.
    //
    //Given a string, return which party will finally win.
    //
    //Example 1:
    //Input: "RD"
    //Output: "Radiant"
    //Explanation: Radiant senator bans the next Dire senator.
    //
    //Example 2:
    //Input: "RDD"
    //Output: "Dire"
    //Explanation: The second Dire senator bans the first Radiant.
    //
    //Constraints:
    //1 <= n <= 10^4
    //s consists only of the characters 'R' and 'D'.

    public class Solution
    {
        public string PredictPartyVictory(string senate)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().PredictPartyVictory("RD");
            Assert.That(result, Is.EqualTo("Radiant"));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().PredictPartyVictory("RDD");
            Assert.That(result, Is.EqualTo("Dire"));
        }
    }
}