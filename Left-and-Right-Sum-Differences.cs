public class Solution 
{
    public int[] LeftRightDifference(int[] nums) 
    {
        int[] result = new int[nums.Length];

        int[] LeftSum = new int[nums.Length];
        int[] RightSum = new int[nums.Length];
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                RightSum[i] += nums[j];
            }
        }
        
        for (int i = nums.Length - 1; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                LeftSum[i] += nums[j];
            }
        }
        
        for(int i = 0; i < nums.Length; i++)
        {
            result[i] = Math.Abs(LeftSum[i] - RightSum[i]);
        }
        

        return result;
    }
}