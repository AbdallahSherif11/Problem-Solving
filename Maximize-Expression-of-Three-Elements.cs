public class Solution 
{
    public int MaximizeExpressionOfThree(int[] nums) 
    {
        int Result = 0;

        Array.Sort(nums);
        Result = nums[nums.Length - 1] + nums[nums.Length - 2] - nums[0];

        return Result;
    }
}