public class Solution 
{
    public int MaxProductDifference(int[] nums) 
    {
        Array.Sort(nums);
        int x = nums.Length;
        return ((nums[x - 1] * nums[x - 2]) - (nums[0] * nums[1]));
    }
}