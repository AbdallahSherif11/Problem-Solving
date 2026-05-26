1public class Solution 
2{
3    public bool IsAdjacentDiffAtMostTwo(string s) 
4    {
5        for(int i = 0; i < s.Length - 1; i++)
6        {
7            if (Math.Abs(s[i] - s[i+1]) > 2)
8            {
9                return false;
10            }
11        }
12
13        return true;
14    }
15}