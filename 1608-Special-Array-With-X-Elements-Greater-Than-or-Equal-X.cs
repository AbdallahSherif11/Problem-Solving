1public class Solution 
2{
3    public int SpecialArray(int[] nums) 
4    {
5        int X = -1;
6        // int Min = nums.Min();
7        int Max = nums.Max();
8        int TempCount = 0;
9
10        for(int i  = 0; i <= Max; i++)
11        {
12            for(int j = 0; j < nums.Length; j++)
13            {
14                if (nums[j] >= i)
15                {
16                    TempCount++;
17                }
18            }
19            if(TempCount == i)
20            {
21                X = i;
22                break;
23            }
24            TempCount = 0;
25        }
26
27
28        return X;
29    }
30}
