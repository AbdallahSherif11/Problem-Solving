public class Solution 
{
    public int[] NumberGame(int[] nums) 
    {
        int[] Result = new int[nums.Length];
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            if ( i % 2 == 0 )
            {
                Result[i] = nums[i+1];
            }
            else
            {
                Result[i] = nums[i-1];
            }
        }
        return Result;
    }
}
