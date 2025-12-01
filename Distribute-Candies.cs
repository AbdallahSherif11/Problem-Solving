1public class Solution 
2{
3    public int DistributeCandies(int[] candyType) 
4    {
5        int DistinctCount = candyType.Distinct().Count();
6        int MaxEat = candyType.Length / 2;
7        if(MaxEat >= DistinctCount)
8        {
9            return DistinctCount;
10        }
11
12
13        return MaxEat;
14    }
15}