1public class Solution 
2{
3    public int ArraySign(int[] nums) 
4    {
5        if(nums.Contains(0))
6        {
7            return 0;
8        }
9
10        if(nums.Count(X=> X < 0) % 2 != 0)
11        {
12            return -1;
13        }
14
15        return 1;
16    }
17}