using System;
using Palindrome.Domain.Models;

namespace Palindrome.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text to check");
            string givenStr = Console.ReadLine();

            PalindromeChecker checker = new PalindromeChecker(givenStr);

            if (checker.CheckIfPalindrome())
            {
                System.Console.WriteLine(checker.ToString() +  " is a palindrome");
            } else {
                System.Console.WriteLine(checker.ToString() +  " not a palindrome");
            }
        }
    }
}
