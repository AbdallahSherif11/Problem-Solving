public class Solution 
{
    public int CountNegatives(int[][] grid) 
    {
        int Result = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            for(int j = 0;  j < grid[i].Length; j++)
            {
                if(grid[i][j] < 0)
                {
                    Result += (grid[i].Length - j);
                    break;
                }
            }
        }

        return Result;
    }
}
