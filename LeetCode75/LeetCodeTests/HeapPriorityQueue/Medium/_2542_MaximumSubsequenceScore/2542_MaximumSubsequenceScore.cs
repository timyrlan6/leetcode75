namespace LeetCodeTests.HeapPriorityQueue.Medium._2542_MaximumSubsequenceScore
{
    //You are given two integer arrays nums1 and nums2 of equal length n and an integer k.
    //
    //Choose a subsequence of indices from [0, n-1] of size k.
    //
    //Let score be the sum of the selected elements from nums1 plus the sum of the selected elements from nums2.
    //
    //Return the maximum possible score.
    //
    //Example 1:
    //Input: nums1 = [1,3,3,2], nums2 = [2,1,3,4], k = 3
    //Output: 12
    //Explanation: Choose indices [0,1,3] (1+3+2=6, 2+1+4=7) score=13. Wait, that's 13. Let me recalculate...
    //Actually the best is indices [1,2,3]: nums1[1]+nums1[2]+nums1[3] = 3+3+2 = 8, nums2[1]+nums2[2]+nums2[3] = 1+3+4 = 8, total = 16.
    //
    //Constraints:
    //n == nums1.length == nums2.length
    //1 <= n <= 10^5
    //1 <= k <= n
    //1 <= nums1[i], nums2[i] <= 10^4

    public class Solution
    {
        public long MaxSubsequenceScore(int[] nums1, int[] nums2, int k)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().MaxSubsequenceScore([1, 3, 3, 2], [2, 1, 3, 4], 3);
            Assert.That(result, Is.EqualTo(16));
        }
    }
}