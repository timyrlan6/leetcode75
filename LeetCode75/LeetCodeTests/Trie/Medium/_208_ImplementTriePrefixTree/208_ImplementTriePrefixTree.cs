namespace LeetCodeTests.Trie.Medium._208_ImplementTriePrefixTree
{
    //Implement a trie with insert, search, and startsWith methods.
    //
    //Example:
    //Input: ["Trie", "insert", "search", "search", "startsWith", "insert", "search"]
    //[[], ["apple"], ["apple"], ["app"], ["app"], ["app"], ["app"]]
    //Output: [null, null, true, false, true, null, true]
    //
    //Constraints:
    //1 <= word.length, prefix.length <= 2000
    //word and prefix consist only of lowercase English letters.
    //At most 10^4 calls in total to insert, search, and startsWith.

    public class Trie
    {
        public Trie()
        {
        }

        public void Insert(string word)
        {
        }

        public bool Search(string word)
        {
            return default;
        }

        public bool StartsWith(string prefix)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var trie = new Trie();
            trie.Insert("apple");
            Assert.That(trie.Search("apple"), Is.EqualTo(true));
            Assert.That(trie.Search("app"), Is.EqualTo(false));
            Assert.That(trie.StartsWith("app"), Is.EqualTo(true));
        }
    }
}