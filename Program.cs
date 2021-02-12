using System;
using System.Collections.Generic;

namespace CrackingCodingInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = {1,2,3};
            int[] nums2 = {0};

            IList<IList<int>> result1 = SubsetSolution.Subsets(nums1);
            IList<IList<int>> result2 = SubsetSolution.Subsets(nums2);
 
            foreach(var list in result1)
            {
                Console.Out.Write("[");
                foreach(var res in list)
                {
                    Console.Out.Write(res + ",");
                }
                Console.Out.Write("]");
            }
            Console.Out.WriteLine("divider");
            foreach(var list in result2)
            {
                Console.Out.Write("[");
                foreach(var res in list)
                {
                    Console.Out.Write(res);
                }
                Console.Out.Write("]");
            }
        }
    }
}
