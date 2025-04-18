public class Solution 
{
    public int MinOperations(int[] nums, int k) 
    {
        int CountOperations = 0;
        for(int i = 0; i< nums.Length; i++)
        {
            if(nums[i] < k) 
            {
                CountOperations++;
            }
        }

        return CountOperations;
    }
}
