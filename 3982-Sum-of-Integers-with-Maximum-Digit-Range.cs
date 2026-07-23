public class Solution 
{
    public int MaxDigitRange(int[] nums) 
    {
        int Result = 0;
        int MaxRange = 0;
        int TempRange = 0;
        string X = "";

        List<List<int>> MyList = new List<List<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            X = nums[i].ToString();
            char[] Xarr = X.ToCharArray();
            Array.Sort(Xarr);
            TempRange = Xarr[Xarr.Length - 1] - Xarr[0];
            MyList.Add([nums[i], TempRange]);
            if (TempRange > MaxRange)
            {
                MaxRange = TempRange;
            }
        }
        foreach (var Z in MyList)
        {
            if (Z[1] == MaxRange)
            {
                Result += Z[0];
            }
        }

        return Result;
    }
}