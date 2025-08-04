public class Solution 
{
    public int CountPrefixSuffixPairs(string[] words)
    {
        int Result = 0;

        for (int i = 0; i < words.Length-1; i++)
        {
            for(int j = i+1; j < words.Length; j++)
            {
                if (isPrefixAndSuffix(words[i], words[j]))
                {
                    Result++;
                }
            }
        }

        return Result;
    }
    public bool isPrefixAndSuffix(string str1, string str2)
    {
        if(str2.StartsWith(str1) && str2.EndsWith(str1))
        {
            return true;
        }
        return false;
    }
}
