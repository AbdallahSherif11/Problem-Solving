public class Solution 
{
    public int[][] AllCellsDistOrder(int rows, int cols, int rCenter, int cCenter) 
    {
        int[][] Result = new int[rows* cols][];

        for (int i = 0; i < Result.Length; i++)
        {
            Result[i] = new int[2];
        }
        int X = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Result[X][0] = i;
                Result[X][1] = j;
                X++;
            }
        }
        //var sorted = Result.OrderBy(inner => inner.Sum()).ToArray();
        var sorted = Result.OrderBy(inner => Math.Abs(Math.Abs(inner[0]) - Math.Abs(rCenter)) + Math.Abs(Math.Abs(inner[1]) - Math.Abs(cCenter))).ToArray();

        return sorted;
    }
}