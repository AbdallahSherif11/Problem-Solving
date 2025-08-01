public class Solution 
{
    public int MinTimeToType(string word) 
    {
        int Result = 0;
        word = "a" + word;

        for(int i = 0; i < word.Length - 1; i++)
        {
            Result++;
            if (Math.Abs(word[i+1] - word[i]) > 13)
            {
                Result += (26 - ( Math.Abs(word[i + 1] - word[i])) );
            }
            else
            {
                Result += Math.Abs(word[i + 1] - word[i]);
            }
        }

        return Result;
    }
}