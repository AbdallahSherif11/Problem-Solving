public class Solution 
{
    public int MaximumUnits(int[][] boxTypes, int truckSize) 
    {
        int Result = 0;
        var x = boxTypes.OrderByDescending(X => X[1]).ToArray();
        for(int i = 0; i < boxTypes.Length; i++)
        {
            while (truckSize > 0 && x[i][0] > 0)
            {
                truckSize--;
                x[i][0]--;
                Result += x[i][1];
            }
        }

        return Result;
    }
}