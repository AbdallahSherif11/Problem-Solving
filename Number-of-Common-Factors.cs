public class Solution 
{
    public int CommonFactors(int a, int b)
    {
        int Count = 0;

        
        for (int i = 1; i <= Math.Min(a, b); i++)
        {
            if (a % i == 0 && b % i == 0)
                Count++;
        }
        

        return Count;
    }
}