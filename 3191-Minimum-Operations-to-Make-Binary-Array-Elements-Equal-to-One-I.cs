public class Solution 
{
    public int MinOperations(int[] nums) 
    {
        int Count = 0;
        int x = 0;

        while ((x = Array.IndexOf(nums, 0)) != -1 && x <= nums.Length - 3)
        {
            for (int j = x; j < x + 3; j++)
            {
                nums[j] ^= 1;
            }
            Count++;
        }
        return nums.Contains(0) ? -1 : Count;
    }
}
