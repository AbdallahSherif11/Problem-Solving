public class Solution 
{
    public int MaximumCount(int[] nums) 
    {
        int CountP = 0;
        int CountN = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                CountP++;
            }
            else if (nums[i] < 0)
            {
                CountN++;
            }
        }

        if(CountP >= CountN)
        {
            return CountP;
        }
        else
        {
            return CountN;
        }
    }
}