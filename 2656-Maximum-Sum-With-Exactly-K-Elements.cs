public class Solution 
{
    public int MaximizeSum(int[] nums, int k) 
    {
        Array.Sort(nums);
        int MaxSum = 0;
        int x = nums.Length - 1;

        for (int i = 0; i < k; i++)
        {
            MaxSum += nums[x];
            nums[x] += 1;
        }

        return MaxSum;
    }
}
