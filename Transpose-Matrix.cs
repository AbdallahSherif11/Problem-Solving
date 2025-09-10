public class Solution 
{
    public int[][] Transpose(int[][] matrix) 
    {
        int[][] Result = new int[matrix[0].Length][];

        for (int i = 0; i < matrix[0].Length; i++)
        {
            Result[i] = new int[matrix.Length];
        }
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                Result[j][i] = matrix[i][j];
            }
        }

        return Result;
    }
}