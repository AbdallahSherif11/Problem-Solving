public class Solution 
{
    public string RemoveOccurrences(string s, string part) 
    {
        while (s.Contains(part))
        {
            s = s.Substring(0, s.IndexOf(part)) + s.Substring(s.IndexOf(part)+part.Length);
        }
        return s;
    }
}
