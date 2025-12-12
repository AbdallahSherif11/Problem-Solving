1public class Solution 
2{
3    public bool ThreeConsecutiveOdds(int[] arr) 
4    {
5        int Count = 0;
6        for(int i = 0; i < arr.Length; i++)
7        {
8            if (arr[i] % 2 != 0)
9            {
10                Count++;
11                if(Count == 3)
12                {
13                    return true;
14                }
15            }
16            else
17            {
18                Count = 0;
19            }
20        }
21
22        return false;
23    }
24}