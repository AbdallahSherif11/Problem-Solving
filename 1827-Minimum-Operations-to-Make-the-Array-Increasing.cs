public class Solution 
{
    public int MinOperations(int[] nums) 
    {
        int count = 0;
        if (nums.Length == 1)
        {
            return 0;
        }
        else
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i + 1] > nums[i])
                {
                    continue;
                }
                else
                {
                    count += nums[i] - nums[i + 1] + 1;
                    nums[i+1] = nums[i] + 1;
                }
            }
            return count;
        }
    }
}
