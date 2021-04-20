using System;
using System.Collections.Generic;

namespace CrackingCodingInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {2, 2};
            
            var solution = new MinimumNumbersOfFunctionCallsToMakeTargetArray();
            solution.AssignResult(nums);
            solution.PrintResult();
        }
    }
}
