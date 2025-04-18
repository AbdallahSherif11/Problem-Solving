public class Solution 
{
    public int[] RunningSum(int[] nums) 
    {
        int[] RunningSum = new int[nums.Length];
        int TempSum = 0;

        for (int i = 0;i < nums.Length; i++)
        {
            TempSum = 0;
            for (int j = 0; j <= i; j++)
            {
                TempSum += nums[j];
            }
            RunningSum[i] = TempSum;
        }

        return RunningSum;
    }
}
