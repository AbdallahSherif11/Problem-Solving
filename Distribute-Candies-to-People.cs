1public class Solution 
2{
3    public int[] DistributeCandies(int candies, int num_people) 
4    {
5        int[] Result = new int[num_people];
6        int i = 0;
7        int j = 1;
8
9        while(candies > 0)
10        {
11            if(j >= candies)
12            {
13                Result[i] += candies;
14            }
15            else
16            {
17                Result[i] += j;
18            }
19            candies -= j;
20
21            i++;
22            j++;
23            if(i >= num_people)
24            {
25                i = 0;
26            }
27        }
28
29        return Result;
30    }
31}