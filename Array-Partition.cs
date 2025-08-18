public class Solution 
{
    public int ArrayPairSum(int[] nums) 
    {
        Array.Sort(nums);
        int Result = 0;

        for(int i  = 0; i < nums.Length - 1;i+=2)
        {
            Result += Math.Min(nums[i] , nums[i + 1]);
        }

        return Result;
    }
}