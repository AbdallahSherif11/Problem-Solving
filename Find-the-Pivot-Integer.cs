public class Solution 
{
    public int PivotInteger(int n) 
    {
        int x = 0;
        int Sum1 = 0;
        int Sum2 = 0;

        for (int i = 1; i <= n; i++)
        {
            Sum1 = 0;
            Sum2 = 0;
            x = i;
            for (int j = 1; j <= x; j++)
            {
                Sum1 += j;
            }
            for (int j = x; j <= n; j++)
            {
                Sum2 += j;
                if(Sum2 > Sum1)
                {
                    break;
                }
            }
            if (Sum1 == Sum2)
            {
                return x;
            }
            else
            {
                x = -1;
            }
        }

        return x;
    }
}