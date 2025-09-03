public class Solution 
{
    public IList<string> SplitWordsBySeparator(IList<string> words, char separator) 
    {
        List<string> Result = new List<string>();

        foreach (string word in words)
        {
            var Temp = word.Split(separator);
            foreach (string word2 in Temp)
            {
                if (word2 != string.Empty)
                {
                    Result.Add(word2);
                }
            }
        }

        return Result;
    }
}
