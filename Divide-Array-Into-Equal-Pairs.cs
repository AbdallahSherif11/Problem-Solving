public class Solution 
{
    public bool DivideArray(int[] nums)
    {
        if(nums.Length % 2 == 0)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums.Count(n => n == nums[i]) % 2 != 0)
                {
                    return false;
                }
            }
            return true;
        }
        else
        {
            return false;
        }
    }
}