public class Solution 
{
    public string[] FindRelativeRanks(int[] score) 
    {
        string[] Result = new string[score.Length];

        int[] Original = new int[score.Length];
        Array.Copy(score, Original, score.Length);
        Array.Sort(score); // After Sorting
        Array.Reverse(score);
        for(int i = 0; i < score.Length; i++)
        {
            int X = Array.IndexOf(score, Original[i]);
            if(X == 0)
            {
                Result[i] = "Gold Medal";
            }
            else if(X == 1)
            {
                Result[i] = "Silver Medal";
            }
            else if (X == 2)
            {
                Result[i] = "Bronze Medal";
            }
            else
            {
                Result[i] = $"{X+1}";
                
            }
        }


        return Result;
    }
}
