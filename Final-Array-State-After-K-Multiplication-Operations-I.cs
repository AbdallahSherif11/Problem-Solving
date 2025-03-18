public class Solution 
{
    public int[] GetFinalState(int[] nums, int k, int multiplier) 
    {
        for(int i = 0; i < k; i++)
        {
            nums[Array.IndexOf(nums, nums.Min())] = nums.Min() * multiplier;
        }

        return nums;
    }
}