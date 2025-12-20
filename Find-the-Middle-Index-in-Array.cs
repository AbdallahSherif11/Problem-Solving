1public class Solution 
2{
3    public int FindMiddleIndex(int[] nums) 
4    {
5        int Left = 0;
6        int Right = 0;
7
8        for (int i  = 0; i < nums.Length; i++)
9        {
10            Left = 0;
11            Right = 0;
12            for(int j = 0; j < i; j++)
13            {
14                Left += nums[j];
15            }
16            for(int k = i + 1; k < nums.Length; k++)
17            {
18                Right += nums[k];
19            }
20            if(Left == Right)
21            {
22                return i;
23            }
24        }
25
26        return -1;
27    }
28}