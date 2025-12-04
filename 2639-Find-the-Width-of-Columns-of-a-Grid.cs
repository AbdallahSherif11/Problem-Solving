1public class Solution 
2{
3    public int[] FindColumnWidth(int[][] grid) 
4    {
5        int[] Result = new int[grid[0].Length];
6
7        for(int i = 0; i < grid.Length; i++)
8        {
9            for(int j = 0; j < grid[i].Length; j++)
10            {
11                if (grid[i][j].ToString().Length > Result[j])
12                {
13                    Result[j] = grid[i][j].ToString().Length;
14                }
15            }
16        }
17
18        return Result;
19    }
20}
