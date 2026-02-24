1public class Solution 
2{
3    public int MinimumDifference(int[] nums, int k) 
4    {
5        int Result = int.MaxValue;
6        Array.Sort(nums);
7        for(int i  = 0; i < nums.Length; i++)
8        {
9            if ((i + k - 1) < nums.Length)
10            {
11                if (nums[i + k - 1] - nums[i] < Result)
12                {
13                    Result = nums[i + k - 1] - nums[i];
14                }
15            }
16        }
17
18        return Result;
19    }
20}