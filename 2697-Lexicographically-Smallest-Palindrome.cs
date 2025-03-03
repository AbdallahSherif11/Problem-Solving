public class Solution 
{
    public string MakeSmallestPalindrome(string s) 
    {
        char[] Temp = s.ToCharArray();
        for(int i = 0; i < s.Length; i++)
        {
            if (s[i] != s[s.Length - i - 1] && s[i] > s[s.Length - i - 1])
            {
                Temp[i] = Temp[Temp.Length - i - 1];
            }
        }
        return string.Concat(Temp);
    }
}
