public class Solution 
{
    public int[] GetSneakyNumbers(int[] nums) 
    {
        int[] SneakyNumbers = new int[2];
        int insert = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i+1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    SneakyNumbers[insert] = nums[i];
                    insert++;
                }
            }
        }

        return SneakyNumbers;
    }
}