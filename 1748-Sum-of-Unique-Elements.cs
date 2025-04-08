public class Solution 
{
    public int SumOfUnique(int[] nums) 
    {
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums.Count(n=> n == nums[i]) == 1)
            {
                sum += nums[i];
            }
        }
        return sum;
    }
}
