namespace LeetCodeTests.Graphs.Medium._399_EvaluateDivision
{
    //You are given an array of variable pairs equations and an array of real numbers values, where equations[i] = [Ai, Bi] and values[i] = valuesi.
    //
    //Return an array of answers where answer[i] is the answer to the ith equation.
    //
    //If the answer does not exist, return -1.0.
    //
    //Example 1:
    //Input: equations = [["a","b"],["b","c"]], values = [2.0,3.0]
    //Output: [6.0,0.5]
    //Explanation: a / b = 2.0, b / c = 3.0, so a / c = 2.0 * 3.0 = 6.0
    //
    //Example 2:
    //Input: equations = [["a","b"],["b","c"],["c","a"]], values = [2.0,3.0,-1.0]
    //Output: [6.0,-1.0,1.0]
    //
    //Constraints:
    //1 <= equations.length <= 1000
    //equations[i].length == 2
    //1 <= Ai.length, Bi.length <= 5
    //Ai and Bi consist of lowercase English letters.
    //values.length == equations.length
    //0.0 < values[i] <= 1000.0

    public class Solution
    {
        public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var equations = new[] { new[] { "a", "b" }, new[] { "b", "c" } };
            var values = new double[] { 2.0, 3.0 };
            var queries = new[] { new[] { "a", "c" }, new[] { "b", "a" } };
            var result = new Solution().CalcEquation(equations, values, queries);
            Assert.That(result[0], Is.EqualTo(6.0).Within(0.001));
            Assert.That(result[1], Is.EqualTo(0.5).Within(0.001));
        }
    }
}