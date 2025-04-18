public class Solution 
{
    public int MinElement(int[] nums) 
    {
        int TempSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            TempSum = 0;
            while (nums[i] > 0)
            {
                TempSum += (nums[i] % 10);
                nums[i] /= 10;
            }
            nums[i] = TempSum;
        }
        int LowestSum = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < LowestSum)
            {
                LowestSum = nums[i];
            }
        }
        return LowestSum;
    }
}