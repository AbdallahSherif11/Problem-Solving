public class Solution 
{
    public void ReverseString(char[] s) 
    {
        char[] Reverse = new char[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            Reverse[i] = s[s.Length - 1 - i];
        }
        for (int i = 0; i < s.Length; i++)
        {
            s[i] = Reverse[i];
        }
    }
}