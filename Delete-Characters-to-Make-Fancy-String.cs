public class Solution 
{
    public string MakeFancyString(string s) 
    {
        List<char> Result = new List<char>();
        if (s.Length < 3)
        {
            return s;
        }
        for (int i = 0; i < s.Length - 2; i++)
        {
            if (s[i] == s[i + 1] && s[i] == s[i + 2])
            {

            }
            else
            {
                Result.Add(s[i]);
            }
        }
        Result.Add(s[s.Length - 2]);
        Result.Add(s[s.Length - 1]);
        string res = string.Concat(Result.ToArray());

        return res;
    }
}