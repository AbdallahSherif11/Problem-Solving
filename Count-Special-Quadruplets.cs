1public class Solution 
2{
3    public int CountQuadruplets(int[] nums) 
4    {
5        int Result = 0;
6
7        for (int i = 0; i < nums.Length - 3; i++)
8        {
9            for(int j = i+1; j < nums.Length - 2; j++)
10            {
11                for(int k = j+1; k < nums.Length - 1; k++)
12                {
13                    for(int l = k+1; l < nums.Length; l++)
14                    {
15                        if (nums[i] + nums[j] + nums[k] == nums[l])
16                        {
17                            Result++;
18                        }
19                    }
20                }
21            }
22        }
23
24        return Result;
25    }
26}