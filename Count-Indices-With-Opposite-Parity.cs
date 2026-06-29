1public class Solution 
2{
3    public int[] CountOppositeParity(int[] nums) 
4    {
5        int[] Result = new int[nums.Length];
6        int Temp = 0;
7
8        for(int i = 0; i < nums.Length; i++)
9        {
10            Temp = 0;
11            if (nums[i] % 2 == 0)
12            {
13                for(int j = i+1; j < nums.Length; j++)
14                {
15                    if(nums[j] % 2 == 1)
16                    {
17                        Temp++;
18                    }
19                }
20            }
21            else
22            {
23                for (int j = i + 1; j < nums.Length; j++)
24                {
25                    if (nums[j] % 2 == 0)
26                    {
27                        Temp++;
28                    }
29                }
30            }
31            Result[i] = Temp; 
32        }
33
34        return Result;
35    }
36}