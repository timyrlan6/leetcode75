namespace LeetCodeTests.ArrayAndString.Easy._345_ReverseVowelsOfAString
{
    //Given a string s, reverse only all the vowels in the string and return it.
//The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases.
//
//Example 1:
//Input: s = "hello"
//Output: "holle"
//
//Example 2:
//Input: s = "leetcode"
//Output: "leotcede"
//
//Constraints:
//1 <= s.length <= 3 * 10^5
//s consist of printable ASCII characters.

    public class Solution
    {
        public const string Vowels = "aeiou";

        public string ReverseVowels(string s)
        {
            var left = -1;

            var right = s.Length;
            var arr = s.ToArray();
            bool seachLeft = true;
            while (left < right)
            {
                if (seachLeft)
                {
                    ++left;
                    if (left>=s.Length) break;
                    if (Vowels.Contains(arr[left], StringComparison.InvariantCultureIgnoreCase)) seachLeft = false;
                }
                else
                {
                    if (Vowels.Contains(arr[--right], StringComparison.InvariantCultureIgnoreCase))
                    {
                        seachLeft = true;
                        (arr[left], arr[right]) = (arr[right], arr[left]);
                    }
                }
            }

            return new string(arr);
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var result = new Solution().ReverseVowels("hello");
            Assert.That(result, Is.EqualTo("holle"));
        }

        [Test]
        public void Test2()
        {
            var result = new Solution().ReverseVowels("leetcode");
            Assert.That(result, Is.EqualTo("leotcede"));
        }

        [Test]
        public void Test3()
        {
            var result = new Solution().ReverseVowels("IceCreAm");
            Assert.That(result, Is.EqualTo("AceCreIm"));
        }

        [Test]
        public void Test4()
        {
            var result = new Solution().ReverseVowels(" ");
            Assert.That(result, Is.EqualTo(" "));
        }
    }
}