public class Solution 
{
    public int CountWords(string[] words1, string[] words2) 
    {
        int Result = 0;

        foreach(var wrod in  words1)
        {
            if(words1.Count(X=> X == wrod) == 1 && words2.Count(X => X == wrod) == 1)
            {
                Result++;
            }
        }

        return Result;
    }
}