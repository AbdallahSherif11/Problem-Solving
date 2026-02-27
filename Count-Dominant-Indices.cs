1public class Solution 
2{
3    public int DominantIndices(int[] nums) 
4    {
5        int Result = 0;
6        int Count = 0;
7        int Average = 0;
8        int TempTotal = 0;
9
10        for(int i = 0; i < nums.Length - 1; i++)
11        {
12            Count = 0;
13            Average = 0;
14            TempTotal = 0;
15
16            for(int j = i+1; j < nums.Length; j++)
17            {
18                TempTotal += nums[j];
19                Count++;
20            }
21            Average = TempTotal / Count;
22            if (nums[i]> Average)
23            {
24                Result++;
25            }
26
27        }
28
29        return Result;
30    }
31}