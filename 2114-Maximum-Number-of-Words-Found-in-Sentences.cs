public class Solution 
{
    public int MostWordsFound(string[] sentences) 
    {
        int MaxWords = 0;

        for (int i = 0; i < sentences.Length; i++)
        {
            if(sentences[i].Split(" ").Length > MaxWords)
            {
                MaxWords = sentences[i].Split(" ").Length;
            }
        }

        return MaxWords;
    }
}
