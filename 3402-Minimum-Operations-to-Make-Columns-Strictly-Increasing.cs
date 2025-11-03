public class Solution 
{
    public int MinimumOperations(int[][] grid) 
    {
        int Result = 0;
        for(int i = 0; i < grid.Length - 1; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                while(grid[i + 1][j] <= grid[i][j])
                {
                    grid[i + 1][j]++;
                    Result++;
                }
            }
        }
        return Result;
    }
}
