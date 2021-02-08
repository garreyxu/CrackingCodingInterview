using System;

namespace CrackingCodingInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            string source1 = "hello";
            string target1 = "ll";
            string source2 = "aaaaa";
            string target2 = "bba";
            string source3 = "aaa";
            string target3 = "a";

            Console.Out.WriteLine(StrStrSulution.StrStr(source1, target1));
            Console.Out.WriteLine(StrStrSulution.StrStr(source2, target2));
            Console.Out.WriteLine(StrStrSulution.StrStr(source3, target3));
        }
    }
}
