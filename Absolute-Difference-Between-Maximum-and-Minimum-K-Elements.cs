1public class Solution 
2{
3    public int AbsDifference(int[] nums, int k) 
4    {
5        int Result = 0;
6
7        Array.Sort(nums);
8        int SumMax = 0;
9        int SumMin = 0;
10
11        for (int i = 0; i < k; i++)
12        {
13            SumMax += nums[i];
14        }
15        for (int i = nums.Length - 1; i >= nums.Length - k; i--)
16        {
17            SumMin += nums[i];
18        }
19
20        Result = Math.Abs(SumMax - SumMin);
21
22        return Result;
23    }
24}