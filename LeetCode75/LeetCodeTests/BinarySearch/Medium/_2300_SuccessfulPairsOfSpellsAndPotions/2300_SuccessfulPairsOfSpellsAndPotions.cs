namespace LeetCodeTests.BinarySearch.Medium._2300_SuccessfulPairsOfSpellsAndPotions
{
    //You are given two integer arrays spells and potions of length n and m respectively, and an integer success.
    //
    //A spell and potion pair is successful if spells[i] * potions[j] >= success.
    //
    //Return an array of length n where answer[i] is the number of potions that are successful with spells[i].
    //
    //Example 1:
    //Input: spells = [5,1,3], potions = [1,2,3,4,5], success = 7
    //Output: [4,0,3]
    //
    //Constraints:
    //n == spells.length
    //m == potions.length
    //1 <= n, m <= 10^5
    //1 <= spells[i], potions[i] <= 10^5
    //1 <= success <= 10^10

    public class Solution
    {
        public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
        {        
            potions = potions.Order().ToArray();
            spells = spells.Select(c=>(int)Math.Ceiling((double)success/c)).ToArray();


            for (int i = 0; i < spells.Length; i++)
            {
                var search = Search(potions, 0, potions.Length - 1, spells[i]);
                spells[i] = potions.Length - search;
            }

            return spells;
        }

        private int Search(int[] potions, int left, int right, long search)
        {
            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (potions[mid] >= search)
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return left;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().SuccessfulPairs([5, 1, 3], [1, 2, 3, 4, 5], 7);
            Assert.That(result, Is.EquivalentTo(new[] { 4, 0, 3 }));
        }
    }
}