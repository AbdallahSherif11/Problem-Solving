public class Solution 
{
    public int[] SumZero(int n) 
    {
        List<int> Result = new List<int>();
        if (n % 2 == 1)
        {
            Result.Add(0);
            n--;
        }
        for (int i = 1; i <= n / 2; i++)
        {
            Result.Add(i);
        }
        for (int i = n / 2; i >= 1; i--)
        {
            Result.Add(-i);
        }

        return Result.ToArray();
    }
}
