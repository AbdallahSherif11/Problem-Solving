public class Solution 
{
    public int CanBeTypedWords(string text, string brokenLetters) 
    {
        int Result = 0;
        string[] Temp = text.Split(' ');
        char[] broken = brokenLetters.ToArray();

        foreach (string s in Temp)
        {
            foreach (char c in broken)
            {
                if (s.Contains(c))
                {
                    Result++;
                    break;
                }
            }
        }

        return Temp.Length - Result;
    }
}