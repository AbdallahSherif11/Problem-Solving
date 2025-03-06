public class Solution 
{
    public int[] FindMissingAndRepeatedValues(int[][] grid) 
    {
        int Maxx = (int)Math.Pow(grid.Length, 2);
        int[] Result = new int[2];

        for(int x = 1; x <= Maxx; x++)
        {
            int Temp = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if( grid[i][j] == x) 
                    {
                        Temp++;
                    }
                }
            }
            if (Temp == 2)
            {
                Result[0] = x;
            }
            if(Temp == 0)
            {
                Result[1] = x;
            }
        }

        return Result;
    }
}
