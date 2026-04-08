namespace LeetCodeTests.HeapPriorityQueue.Medium._2336_SmallestNumberInInfiniteSet
{
    //Design a data structure that supports adding a number and getting the smallest number in the set.
    //
    //Implement the SmallestInfiniteSet class:
    //- SmallestInfiniteSet() Initializes the object with positive integers 1 to infinity.
    //- int popSmallest() Removes and returns the smallest element from the set.
    //- void addBack(int num) Adds a positive integer num back into the set, if it was not already present.
    //
    //Example 1:
    //Input: ["SmallestInfiniteSet", "addBack", "popSmallest", "popSmallest", "popSmallest", "addBack", "popSmallest", "popSmallest", "popSmallest"]
    //[[], [2], [], [], [], [1], [], [], []]
    //Output: [null, null, 1, 2, 3, null, 1, 2, 4]
    //
    //Constraints:
    //1 <= num <= 10^6
    //At most 10^4 calls will be made in total to popSmallest and addBack.

    public class SmallestInfiniteSet
    {
        public SmallestInfiniteSet()
        {
        }

        public int PopSmallest()
        {
            return default;
        }

        public void AddBack(int num)
        {
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var set = new SmallestInfiniteSet();
            set.AddBack(2);
            Assert.That(set.PopSmallest(), Is.EqualTo(1));
            Assert.That(set.PopSmallest(), Is.EqualTo(2));
        }
    }
}