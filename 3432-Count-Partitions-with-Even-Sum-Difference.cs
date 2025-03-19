public class Solution 
{
    public int CountPartitions(int[] nums) 
    {
        int Count = 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            List<int> Left = new List<int>();
            List<int> Right = new List<int>();
            for (int j = 0; j < i + 1; j++)
            {
                Left.Add(nums[j]);
            }
            for (int k = i + 1; k < nums.Length; k++)
            {
                Right.Add(nums[k]);
            }
            if((Left.Sum() - Right.Sum()) % 2 == 0)
                Count++;
        }

        return Count;
    }
}
