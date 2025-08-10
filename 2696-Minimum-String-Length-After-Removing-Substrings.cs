public class Solution 
{
    public  int MinLength(string s)
    {
        List<char> chars = new List<char>();
        chars = s.ToList();
        for (int i = 0; i < s.Length - 1; i++)
        {
            if ((s[i] == 'A' && s[i+1] == 'B') || (s[i] == 'C' && s[i+1] == 'D'))
            {
                s = s.Remove(i, 2);
                i = -1;
            }
        }
        return s.Length;
    }
}
