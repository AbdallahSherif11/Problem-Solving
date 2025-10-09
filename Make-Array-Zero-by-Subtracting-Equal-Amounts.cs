public class Solution 
{
    public int MinimumOperations(int[] nums) 
    {
        int Result = 0;

        while (nums.Max() != 0)
        {
            int Temp = nums.Where(X=> X != 0).Min();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    nums[i] -= Temp;
                }
            }
            Result++;
        }

        return Result;
    }
}