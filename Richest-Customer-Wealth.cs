public class Solution 
{
    public int MaximumWealth(int[][] accounts) 
    {
        int TempMaximum = 0;
        int Maximum = 0;

        for (int i = 0; i < accounts.Length; i++)
        {
            TempMaximum = 0;
            for (int j = 0; j < accounts[i].Length; j++)
            {
                TempMaximum += accounts[i][j];
            }
            if (TempMaximum > Maximum)
            {
                Maximum = TempMaximum;
            }
        }

        return Maximum;
    }
}