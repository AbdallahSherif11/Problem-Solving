public class Solution 
{
    public int SumOfSquares(int[] nums) 
    {
        int n = nums.Length;
        int Count = 0;
        for (int i = 1; i <= n; i++)
        {
            if(n % i == 0)
            {
                Count += (nums[i-1] * nums[i-1]);
            }
        }

        return Count;
    }
}