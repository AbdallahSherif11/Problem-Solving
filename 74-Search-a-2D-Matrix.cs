public class Solution 
{
    public bool SearchMatrix(int[][] matrix, int target) 
    {
        int L = 0;
        int R = (matrix.Length * matrix[0].Length) - 1;
        
        int M = (R + L) / 2;
        int x = M / matrix[0].Length;
        int y = M % matrix[0].Length;
        while (R >= L)
        {
            if (matrix[x][y] == target)
            {
                return true;
            }
            else if (matrix[x][y] > target)
            {
                R = M - 1;
            }
            else
            {
                L = M + 1;
            }
            M = (R + L) / 2;
            x = M / matrix[0].Length;
            y = M % matrix[0].Length;
        }
        return false;
    }
}
