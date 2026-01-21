1public class Solution 
2{
3    public int SubarraySum(int[] nums) 
4    {
5        int Result = 0;
6        int Temp = 0;
7
8        for(int i = 0; i < nums.Length; i++)
9        {
10            Temp = Math.Max(0, i - nums[i]);
11            for (int j = Temp; j <= i; j++)
12            {
13                Result += nums[j];
14            }
15        }
16
17        return Result;
18    }
19}