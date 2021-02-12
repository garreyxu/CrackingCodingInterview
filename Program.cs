using System;

namespace CrackingCodingInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = "aacecaaa";
            string input2 = "dcbabcd";

            Console.Out.WriteLine(ShortestPalindroneSolution.ShortestPalindrome(input1));
            Console.Out.WriteLine(ShortestPalindroneSolution.ShortestPalindrome(input2));
        }
    }
}
