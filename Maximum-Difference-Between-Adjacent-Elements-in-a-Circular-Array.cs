public class Solution 
{
    public int MaxAdjacentDistance(int[] nums) 
    {
        int Max = Math.Abs(nums[0] - nums[nums.Length - 1]);
        for(int i  = 0; i < nums.Length - 1; i++)
        {
            int Temp = Math.Abs(nums[i] - nums[i + 1]);
            if (Temp > Max)
            {
                Max = Temp;
            }
        }
        return Max;
    }
}