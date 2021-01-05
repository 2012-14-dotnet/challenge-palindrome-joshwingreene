using System;

namespace Palindrome.Domain.Models
{
    public class PalindromeChecker
    {
        string givenStr;

        public PalindromeChecker(string origStr)
        {
            givenStr = origStr;
        }

        public bool CheckIfPalindrome()
        {
            char[] ch = givenStr.ToCharArray();
            Array.Reverse(ch);
            string rev = new string(ch);
            bool b = givenStr.Equals(rev, StringComparison.OrdinalIgnoreCase);

            return b;
        }

        public override string ToString()
        {
            return givenStr;
        }
    }
}