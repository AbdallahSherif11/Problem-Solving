public class Solution 
{
    public int SumOfGoodNumbers(int[] nums, int k) 
    {
        int Result = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if((i - k < 0) && (i + k >= nums.Length))
            {
                Result += nums[i];
            }
            else if(i - k >= 0 && (i + k >= nums.Length))
            {
                if (nums[i] > nums[i-k])
                {
                    Result += nums[i];
                }
            }
            else if(i + k < nums.Length && (i - k < 0))
            {
                if (nums[i] > nums[i + k])
                {
                    Result += nums[i];
                }
            }
            else
            {
                if (nums[i] > nums[i - k] && nums[i] > nums[i + k])
                {
                    Result += nums[i];
                }
            }
        }

        return Result;
    }
}
