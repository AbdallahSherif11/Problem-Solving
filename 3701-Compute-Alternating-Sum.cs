1public class Solution 
2{
3    public int AlternatingSum(int[] nums) 
4    {
5        int Result = 0;
6
7        for (int i = 0; i < nums.Length; i+=2)
8        {
9            Result += nums[i];
10        }
11        for (int i = 1; i < nums.Length; i+=2)
12        {
13            Result -= nums[i];
14        }
15
16        return Result;
17    }
18}
