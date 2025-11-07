public class Solution 
{
    public int PossibleStringCount(string word) 
    {
        int Result = 1;

        for(int i = 0; i < word.Length - 1; i++)
        {
            if(word[i] == word[i + 1])
            {
                Result++;
            }
        }

        return Result;
    }
}