public class Solution 
{
    public int[][] Construct2DArray(int[] original, int m, int n) 
    {
        int[][] Result = new int[m][];
        if(m*n != original.Length)
        {
            return new int[0][];
        }
        int k = 0;
        for(int i = 0; i < Result.Length; i++)
        {
            Result[i] = new int[n];
            for(int j = 0; j < n; j++)
            {
                Result[i][j] = original[k];
                k++;
            }
        }

        return Result;
    }
}
