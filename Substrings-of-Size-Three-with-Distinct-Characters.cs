public class Solution 
{
    public int CountGoodSubstrings(string s) 
    {
        int Result = 0;
        List<string> chars = new List<string>();

        for (int i = 0; i < s.Length - 2; i++)
        {
            chars.Add($"{s[i]}{s[i + 1]}{s[i + 2]}");
        }
        foreach(var X in chars)
        {
            var Y = X.Distinct().ToList();
            if(Y.Count == 3)
            {
                Result++;
            }
        }

        return Result;
    }
}