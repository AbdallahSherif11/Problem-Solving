public class Solution 
{
    public int FindMaxK(int[] nums) 
    {
        int Result = -1;

        nums = nums.Distinct().ToArray();
        Array.Sort(nums);
        foreach (int num in nums)
        {
            if(nums.Count(X => Math.Abs(X) == Math.Abs(num)) == 2)
            {
                Result = Math.Abs(num);
            }
        }

        return Result;
    }
}
