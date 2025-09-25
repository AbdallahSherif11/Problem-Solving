public class Solution 
{
    public int[] RowAndMaximumOnes(int[][] mat) 
    {
        int[] Result = new int[2];
        int TempMax = 0;
        int TempRow = 0;
        for (int i = 0; i < mat.Length; i++)
        {
            int TempCount = 0;
            foreach (var X in mat[i])
            {
                if(X == 1)
                {
                    TempCount++;
                }
            }
            if(TempCount > TempMax)
            {
                TempMax = TempCount;
                TempRow = i;
            }
        }
        Result[0] = TempRow;
        Result[1] = TempMax;

        return Result;
    }
}