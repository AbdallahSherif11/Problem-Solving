public class Solution 
{
    public bool IsAcronym(IList<string> words, string s) 
    {
        string Temp = "";
        for(int i = 0; i < words.Count; i++)
        {
            Temp += words[i][0];
        }
        return Temp == s;
    }
}