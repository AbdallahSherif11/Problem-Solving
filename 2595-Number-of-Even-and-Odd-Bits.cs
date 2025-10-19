public class Solution 
{
    public int[] EvenOddBit(int n) 
    {
        string X = Convert.ToString(n, 2);
        int[] Result = new int[2];
        for(int i = X.Length - 1; i >= 0;i--)
        {
            int y = Math.Abs(i - (X.Length - 1));
            if (X[i] == '1' && y % 2 == 0)
            {
                Result[0]++;
            }
            else if (X[i] == '1' && y % 2 == 1)
            {
                Result[1]++;
            }
        }

        return Result;
    }
}
