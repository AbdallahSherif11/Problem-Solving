public class Solution 
{
    public int RepeatedNTimes(int[] nums) 
    {
        foreach(int num in nums)
        {
            if(nums.Count(X=> X == num) > 1)
            {
                return num;
            }
        }
        return 0;
    }
}