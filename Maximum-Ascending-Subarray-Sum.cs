public class Solution 
{
    public int MaxAscendingSum(int[] nums) 
    {
        int MaxSum = nums[0];
        int TempSum = nums[0];
        for (int i = 0; i < nums.Length - 1;i++)
        {
            if (nums[i] < nums[i + 1])
            {
                TempSum += nums[i+1];
                if (TempSum > MaxSum)
                {
                    MaxSum = TempSum;
                }
            }
            else
            {
                TempSum = nums[i + 1];
            }
        }
        return MaxSum;
    }
}