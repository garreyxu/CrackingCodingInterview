using System;

public abstract class Solution : ISolution
{
    public string Result { get; protected set; }

    public void PrintResult()
    {
        Console.Out.Write(this.Result);
    }
}