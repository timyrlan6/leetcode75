namespace LeetCodeTests.Trie.Medium._1268_SearchSuggestionsSystem
{
    //Given an array of strings products and a string searchWord, design a suggestions system that suggests at most three product names from products after each character of searchWord is typed.
    //
    //Suggestions must follow products lexicographically, and after each character typed, return at most three products with the prefix of the typed string.
    //
    //Example 1:
    //Input: products = ["mobile","mouse","moneypot","monitor","mousepad"], searchWord = "mouse"
    //Output: [["mobile","moneypot","monitor"],["mobile","moneypot","monitor"],["mobile","moneypot","monitor"],["mouse","mousepad"],["mouse","mousepad"],["mouse","mousepad"]]
    //
    //Constraints:
    //1 <= products.length <= 10^3
    //1 <= products[i].length <= 10^3
    //1 <= searchWord.length <= 10^3
    //All strings consist of lowercase English letters.

    public class Solution
    {
        public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            return default;
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().SuggestedProducts(new[] { "mobile", "mouse", "moneypot", "monitor", "mousepad" }, "mouse");
            Assert.That(result.Count, Is.EqualTo(5));
        }
    }
}