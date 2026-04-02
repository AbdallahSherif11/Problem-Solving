1public class Solution 
2{
3    public int MinStartValue(int[] nums) 
4    {
5        int Result = 1;
6        int TempSum = Result;
7
8        for(int i = 0; i < nums.Length; i++)
9        {
10            TempSum += nums[i];
11            if(TempSum < 1)
12            {
13                Result = (Result - TempSum) + 1;
14                TempSum = Result;
15                i = -1;
16            }
17        }
18
19        return Result;
20    }
21}
