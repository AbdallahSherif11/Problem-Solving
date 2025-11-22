public class Solution 
{
    public int[] SortArrayByParityII(int[] nums) 
    {
        int[] Result = new int[nums.Length];
        nums = nums.OrderByDescending(X => X % 2 == 0).ToArray();
        int k = 0;
        for (int i = 0; i < nums.Length; i += 2)
        {
            Result[i] = nums[k];
            k++;
        }
        for (int i = 1; i < nums.Length; i += 2)
        {
            Result[i] = nums[k];
            k++;
        }

        return Result;
    }
}
