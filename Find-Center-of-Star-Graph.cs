1public class Solution 
2{
3    public int FindCenter(int[][] edges) 
4    {
5        List<int> result = new List<int>();
6        result.Add(edges[0][0]);
7        result.Add(edges[0][1]);
8        if(result.Contains(edges[1][0]))
9        {
10            return edges[1][0];
11        }
12        else
13        {
14            return edges[1][1];
15        }
16    }
17}