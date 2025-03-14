public class Solution 
{
    public int[][] LargestLocal(int[][] grid) 
    {
        int[][] result = new int[grid.Length - 2][];
        int tempMax = 0;
        
        for (int i = 0; i < (grid.Length - 2); i++)
        {
            result[i] = new int[grid.Length - 2];
            for (int j = 0; j < (grid.Length - 2); j++)
            {
                for(int k = i; k < i+3; k++)
                {
                    for( int l = j; l < j+3; l++)
                    {
                        if (grid[k][l] > tempMax)
                        {
                            tempMax = grid[k][l];
                        }
                    }
                }
                result[i][j] = tempMax;
                tempMax = 0;
            }
        }

        return result;
    }
}