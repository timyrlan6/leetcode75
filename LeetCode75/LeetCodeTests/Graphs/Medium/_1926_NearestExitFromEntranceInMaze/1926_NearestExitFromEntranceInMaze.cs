namespace LeetCodeTests.Graphs.Medium._1926_NearestExitFromEntranceInMaze
{
    //You are given an m x n matrix maze (0-indexed) with empty cells (represented as '.'), walls (represented as '+'), and a start position (represented as 'E').
    //
    //Find the shortest distance from the start position to any exit.
    //
    //An exit is defined as an empty cell that is at the border of the maze. The start position is not an exit.
    //
    //Return -1 if there is no exit.
    //
    //Example 1:
    //Input: maze = [["+","+",".","+"],[".","+","+","."],[["+","+","+","+"]], entrance = [1,2]
    //Output: 1
    //Explanation: There is 1 step to reach an exit.
    //
    //Example 2:
    //Input: maze = [[".","+"],["+","+"]], entrance = [0,0]
    //Output: -1
    //
    //Constraints:
    //maze.length == maze[i].length
    //1 <= m, n <= 100
    //maze[i][j] is '+' or '.'.
    //entrance is guaranteed to be an empty cell.

    public class Solution
    {
        public int NearestExit(char[][] maze, int[] entrance)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var maze = new char[][] { new[] { '+', '+', '.', '+' }, new[] { '.', '+', '+', '.' }, new[] { '+', '+', '+', '+' } };
            var result = new Solution().NearestExit(maze, new[] { 1, 2 });
            Assert.That(result, Is.EqualTo(1));
        }
    }
}