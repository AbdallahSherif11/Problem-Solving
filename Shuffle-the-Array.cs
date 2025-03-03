public class Solution 
{
    public int[] Shuffle(int[] nums, int n) 
    {
        int[] NewArr = new int[nums.Length];
        for(int i = 0; i < n; i++)
        {
            NewArr[i+i] = nums[i];
        }
        for (int i = n; i < 2*n; i++)
        {
            NewArr[i - n + (i - n + 1)] = nums[i];
        }

        return NewArr;
    }
}