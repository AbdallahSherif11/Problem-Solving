public class Solution 
{
    public IList<int> LuckyNumbers(int[][] matrix) 
    {
        List<int> Result = new List<int>();

        for (int i = 0; i < matrix.Length; i++)
        {
            int X = Array.IndexOf(matrix[i], matrix[i].Min());
            bool Check = true;
            for (int j = 0; j < matrix.Length; j++)
            {
                if (matrix[i][X] < matrix[j][X])
                {
                    Check = false;
                }
            }
            if (Check)
            {
                Result.Add(matrix[i][X]);
            }
        }

        return Result;
    }
}