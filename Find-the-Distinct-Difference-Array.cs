public class Solution 
{
    public int[] DistinctDifferenceArray(int[] nums)
    {
        int[] Result = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            int[] X = nums[..(i+1)].Distinct().ToArray();
            int[] Y = Array.Empty<int>();
            if ((i+1) < nums.Length)
            {
                Y = nums[(i+1)..nums.Length].Distinct().ToArray();
            }
            else
            {
                Y = Array.Empty<int>();
            }
            Result[i] = X.Length - Y.Length;
        }

        return Result;
    }
}