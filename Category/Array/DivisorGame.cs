public class DivisorGameSolution : Solution
{
    public DivisorGameSolution(){}

    public bool DivisorGame(int n)
    {
        return n % 2 == 0;
    }

    public void AssignResult(int nums)
    {
        this.Result = this.DivisorGame(nums).ToString();
    }
}