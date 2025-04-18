public class Solution 
{
    public int[] SmallerNumbersThanCurrent(int[] nums) 
    {
        int[] result = new int[nums.Length];
        int TempMin = 0;
        int TempCount = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            TempMin = nums[i];
            TempCount = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] < TempMin)
                {
                    TempCount++;
                }
            }
            result[i] = TempCount;
        }

        return result;
    }
}
