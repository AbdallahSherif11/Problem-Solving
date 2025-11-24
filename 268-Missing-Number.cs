public class Solution 
{
    public int MissingNumber(int[] nums) 
    {
        int Result = 0;

        int[] All = new int[nums.Length + 1];
        All = Enumerable.Range(0, nums.Length + 1).ToArray();
        var X = All.Except(nums).ToArray();

        return X[0];
    }
}
