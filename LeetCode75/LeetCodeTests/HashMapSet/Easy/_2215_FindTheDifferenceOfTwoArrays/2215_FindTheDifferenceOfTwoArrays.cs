namespace LeetCodeTests.HashMapSet.Easy._2215_FindTheDifferenceOfTwoArrays
{
    //Given two integer arrays nums1 and nums2, return an array of their difference. You should return the array of elements in nums1 that are not in nums2 and the elements in nums2 that are not in nums1.
    //
    //Example 1:
    //Input: nums1 = [1,2,3], nums2 = [2,4,6]
    //Output: [[1,3],[4,6]]
    //Explanation: The elements in nums1 that are not in nums2 are [1,3]. The elements in nums2 that are not in nums1 are [4,6].
    //
    //Example 2:
    //Input: nums1 = [1,2,3,3], nums2 = [1,1,2,2]
    //Output: [[3],[]]
    //Explanation: The elements in nums1 that are not in nums2 are [3]. The elements in nums2 that are not in nums1 are [].
    //
    //Constraints:
    //1 <= nums1.length, nums2.length <= 1000
    //-1000 <= nums1[i], nums2[i] <= 1000

    public class Solution
    {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().FindDifference([1, 2, 3], [2, 4, 6]);
            Assert.That(result[0], Is.EquivalentTo(new[] { 1, 3 }));
            Assert.That(result[1], Is.EquivalentTo(new[] { 4, 6 }));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().FindDifference([1, 2, 3, 3], [1, 1, 2, 2]);
            Assert.That(result[0], Is.EquivalentTo(new[] { 3 }));
            Assert.That(result[1], Is.Empty);
        }
    }
}