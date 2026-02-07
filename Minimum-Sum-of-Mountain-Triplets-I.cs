1public class Solution 
2{
3    public int MinimumSum(int[] nums) 
4    {
5        int Result = int.MaxValue;
6        int Temp = 0;
7        bool ExistMountain = false;
8
9        for(int i = 0; i < nums.Length - 2; i++)
10        {
11            for(int j = i+1; j < nums.Length -1; j++)
12            {
13                for(int k = j+1; k < nums.Length; k++)
14                {
15                    if (nums[i] < nums[j] && nums[j] > nums[k])
16                    {
17                        ExistMountain = true;
18                        Temp = nums[i] + nums[j] + nums[k];
19                        if (Temp < Result)
20                        {
21                            Result = Temp;
22                        }
23                    }
24                }
25            }
26        }
27
28        return ExistMountain ? Result : -1;
29    }
30}