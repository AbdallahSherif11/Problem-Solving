1public class Solution 
2{
3    public int MinMoves(int[] nums) 
4    {
5        int Result = 0;
6        int Max = nums.Max();
7
8        for (int i = 0; i < nums.Length; i++)
9        {
10            Result += (Max - nums[i]);
11        }
12
13        return Result;
14    }
15}