public class Solution 
{
    public int CountPrefixes(string[] words, string s) 
    {
        int Result = 0;

        foreach (string word in words)
        {
            if (s.StartsWith(word))
            {
                Result++;
            }
        }

        return Result;
    }
}
