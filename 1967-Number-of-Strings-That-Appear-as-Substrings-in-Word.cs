public class Solution 
{
    public int NumOfStrings(string[] patterns, string word) 
    {
        int Count = 0;

        for (int i = 0; i < patterns.Length; i++)
        {
            if (word.Contains(patterns[i]))
            {
                Count++;
            }
        }

        return Count;
    }
}
