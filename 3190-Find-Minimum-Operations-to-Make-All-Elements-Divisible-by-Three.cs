public class Solution 
{
    public int MinimumOperations(int[] nums) 
    {
        int NumberOfOperations = 0;
        for (int i = 0; i< nums.Length;i++)
        {
            if (nums[i] % 3 != 0)
            {
                if ((nums[i] - 1) % 3 != 0)
                {
                    nums[i] = nums[i] + 1;
                    NumberOfOperations++;
                }
                else
                {
                    nums[i] = nums[i] - 1;
                    NumberOfOperations++;
                }
            }
        }

        return NumberOfOperations;
    }
}
