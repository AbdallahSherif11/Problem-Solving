1public class Solution 
2{
3    public int NumberOfAlternatingGroups(int[] colors) 
4    {
5        int Result = 0;
6        int myLength = colors.Length;
7
8        for(int i = 0; i < myLength - 2; i++)
9        {
10            if (colors[i] == colors[i + 2] && colors[i+1] != colors[i])
11            {
12                Result++;
13            }
14        }
15
16        if (colors[myLength - 2] == colors[0] && colors[myLength - 1] != colors[myLength - 2])
17        {
18            Result++;
19        }
20        if (colors[myLength - 1] == colors[1] && colors[0] != colors[myLength - 1])
21        {
22            Result++;
23        }
24
25        return Result;
26    }
27}
