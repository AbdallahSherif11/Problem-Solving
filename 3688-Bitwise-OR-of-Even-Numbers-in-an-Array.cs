1public class Solution 
2{
3    public int EvenNumberBitwiseORs(int[] nums) 
4    {
5        int Result = 0;
6        for (int i = 0; i < nums.Length; i++)
7        {
8            if (nums[i] % 2 == 0) 
9            {
10                Result |= nums[i];
11            }
12        }
13        return Result;
14    }
15}
