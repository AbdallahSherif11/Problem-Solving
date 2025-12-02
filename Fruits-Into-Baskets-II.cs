1public class Solution 
2{
3    public int NumOfUnplacedFruits(int[] fruits, int[] baskets) 
4    {
5        int Result = 0;
6        for (int i = 0; i < fruits.Length; i++)
7        {
8            int j = 0;
9            for (j = 0; j < baskets.Length; j++)
10            {
11                if (baskets[j] >= fruits[i])
12                {
13                    fruits[i] = 0;
14                    baskets[j] = 0;
15                    break;
16                }
17            }
18            if (j == baskets.Length)
19            {
20                Result++;
21            }
22
23        }
24
25        return Result;
26    }
27}