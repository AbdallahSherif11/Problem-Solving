public class Solution 
{
    public int MinimumCost(int[] nums) 
    {
        int Result = nums[0];
        List<int> Temp = new List<int>(nums[1..nums.Length]);

        Temp.Sort();
        Result += Temp[0];
        Result += Temp[1];

        return Result;
    }
}