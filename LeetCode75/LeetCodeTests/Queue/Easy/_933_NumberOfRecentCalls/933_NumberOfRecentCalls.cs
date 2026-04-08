namespace LeetCodeTests.Queue.Easy._933_NumberOfRecentCalls
{
    //You have a RecentCounter class which counts the number of recent requests within a certain time frame.
    //
    //Implement the RecentCounter class:
    //- RecentCounter() Initializes the counter with zero recent requests.
    //- int ping(int t) Adds a new request at time t, where t represents the time (in milliseconds) of the request. Returns the number of requests that have happened in the past 3000 milliseconds (including the new request).
    //
    //Example 1:
    //Input: ["RecentCounter", "ping", "ping", "ping", "ping"], [[], [1], [100], [3001], [3002]]
    //Output: [null, 1, 2, 3, 3]
    //
    //Constraints:
    //1 <= t <= 10^9
    //Each test case calls ping with strictly increasing values of t.
    //At most 10^4 calls are made to ping.

    public class RecentCounter
    {
        public RecentCounter()
        {
        }

        public int Ping(int t)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var counter = new RecentCounter();
            Assert.That(counter.Ping(1), Is.EqualTo(1));
            Assert.That(counter.Ping(100), Is.EqualTo(2));
            Assert.That(counter.Ping(3001), Is.EqualTo(3));
            Assert.That(counter.Ping(3002), Is.EqualTo(3));
        }
    }
}