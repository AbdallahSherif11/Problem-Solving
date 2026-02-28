1public class Solution 
2{
3    public int MaxDistance(int[] colors) 
4    {
5        int Result = 0;
6
7        for(int i  = 0; i < colors.Length - 1; i++)
8        {
9            for(int j = colors.Length - 1; j > i; j--)
10            {
11                if (colors[i] != colors[j] && Math.Abs(i-j) > Result)
12                {
13                    Result = Math.Abs(i - j);
14                    break;
15                }
16            }
17        }
18
19        return Result;
20    }
21}