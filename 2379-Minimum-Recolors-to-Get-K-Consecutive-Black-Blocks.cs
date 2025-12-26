1public class Solution 
2{
3    public int MinimumRecolors(string blocks, int k) 
4    {
5        List<int> Mins = new List<int>();
6
7        for(int i = 0; i <= blocks.Length - k; i++)
8        {
9            Mins.Add(blocks.Substring(i,k).Where(X=> X == 'W').Count());
10        }
11
12        return Mins.Min();
13    }
14}
