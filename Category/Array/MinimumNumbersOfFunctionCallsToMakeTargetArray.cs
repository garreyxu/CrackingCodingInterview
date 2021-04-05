using System;

public class MinimumNumbersOfFunctionCallsToMakeTargetArray : Solution
{
    public MinimumNumbersOfFunctionCallsToMakeTargetArray(){}
    
    public int MinOperations(int[] nums)
    {
        int[] ans = new int[2];

        foreach(int num in nums)
        {
            if(num == 0)
            {
                continue;
            }
            else
            {
                CalculateOps(num, ans);
            }
        }

        return ans[0] + ans[1];
    }

    private void CalculateOps(int num, int[] ans)
    {
        int plus = 0;
        int divid = 0;

        while(num > 0)
        {
            if(num % 2 > 0)
            {
                num--;
                plus++;
            }
            else
            {
                num /= 2;
                divid++;
            }
        }

        ans[0] += plus;
        ans[1] = Math.Max(ans[1], divid); 
    }

    public void AssignResult(int[] nums)
    {
        this.Result = this.MinOperations(nums).ToString();
    }
}
