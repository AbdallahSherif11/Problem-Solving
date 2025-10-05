public class Solution 
{
    public int IslandPerimeter(int[][] grid) 
    {
        int Result = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 1)
                {
                    Result += 4;
                    if(j+1 < grid[i].Length && grid[i][j+1] == 1)
                    {
                        Result--;
                    }
                    if (j - 1 >= 0 && grid[i][j - 1] == 1)
                    {
                        Result--;
                    }

                    if (i + 1 < grid.Length && grid[i + 1][j] == 1)
                    {
                        Result--;
                    }
                    if (i - 1 >= 0 && grid[i - 1][j] == 1)
                    {
                        Result--;
                    }
                }
            }
        }

        return Result;
    }
}