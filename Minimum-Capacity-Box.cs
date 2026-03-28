1public class Solution 
2{
3    public int MinimumIndex(int[] capacity, int itemSize) 
4    {
5        int Result = -1;
6        int CurrentMin = int.MaxValue;
7
8        for(int i = 0; i < capacity.Length; i++)
9        {
10            if (capacity[i] >= itemSize)
11            {
12                if (CurrentMin != capacity[i] && CurrentMin > capacity[i])
13                {
14                    Result = i;
15                    CurrentMin = capacity[i];
16                }
17            }
18        }
19
20        return Result;
21    }
22}