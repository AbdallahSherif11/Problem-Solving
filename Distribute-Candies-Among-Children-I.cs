public class Solution 
{
    public int DistributeCandies(int n, int limit) 
    {
        int Start = limit;
        int Result = 0;

        for (int i = limit; i >= 0; i--)
        {
            for (int j = limit; j >= 0; j--)
            {
                for (int k  = limit; k >= 0; k--)
                {
                    if (i + j + k == n)
                    {
                        Result++;
                    }
                }
            }
        }

        return Result;
    }
}