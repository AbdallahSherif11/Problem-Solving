1public class Solution 
2{
3    public int MirrorDistance(int n) 
4    {
5        int Result = 0;
6        int ReversedN = int.Parse(n.ToString().Reverse().ToArray());
7
8        Result = Math.Abs(n - ReversedN);
9        return Result;
10    }
11}
