public class Solution 
{
    public int DiagonalSum(int[][] mat) 
    {
        int Sum = 0;
        int X = mat.Length;

        for (int i = 0; i < X; i++)
        {
            for (int j = 0; j < X; j++)
            {
                if((i == j))
                {
                    Sum += mat[i][j];
                }
            }
            Sum += mat[i][X-i-1];
        }
        if (X % 2 != 0)
        {
            Sum -= mat[X / 2][X / 2];
        }

        return Sum;
    }
}