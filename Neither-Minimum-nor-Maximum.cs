public class Solution 
{
    public int FindNonMinOrMax(int[] nums) 
    {
        int Max = nums.Max();
        int Min = nums.Min();
        int X = nums.FirstOrDefault(n=> n != Max && n != Min, -1);

        return X;
    }
}