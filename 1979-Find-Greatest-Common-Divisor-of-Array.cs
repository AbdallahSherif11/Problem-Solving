public class Solution 
{
    public int FindGCD(int[] nums) 
    {
        int min = nums.Min();
        int max = nums.Max();
        if(max % min == 0)
        {
            return min;
        }
        else
        {
            for(int i = min - 1; i >= 1; i--)
            {
                if((min % i == 0) && (max % i == 0))
                {
                    return i;
                }
            }
            return min;
        }
    }
}
