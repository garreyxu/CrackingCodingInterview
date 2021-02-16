using System;
using System.Collections.Generic;

class SubsetSolution
{
    public SubsetSolution(){}

    public static IList<IList<int>> Subsets(int[] nums) 
    {
        IList<int> subset = new List<int>();
        IList<IList<int>> result = new List<IList<int>>();

        if(nums == null)
        {
            return result;
        }
        if(nums.Length == 0)
        {
            result.Add(subset);
            return result;
        }

        Array.Sort(nums);

        dfs(result, subset, nums, 0);

        return result;
        
    }

    private static void dfs(IList<IList<int>> result,
                    IList<int> subset,
                    int[] nums,
                    int startIndex)
    {
        result.Add(new List<int>(subset));

        for(int i = startIndex; i < nums.Length; i++)
        {
            subset.Add(nums[i]);

            dfs(result, subset, nums, i+1);

            subset.Remove(nums[i]);
        }
        

    }
}