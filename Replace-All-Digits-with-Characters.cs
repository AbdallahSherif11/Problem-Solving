public class Solution 
{
    public string ReplaceDigits(string s) 
    {
        char[] theAlphabet = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'];
        char[] sChars = s.ToCharArray();

        for (int i = 1; i < sChars.Length; i+=2)
        {
            int x = Array.IndexOf(theAlphabet, sChars[i - 1]);
            sChars[i] = theAlphabet[x + int.Parse(sChars[i].ToString())];
        }

        return string.Concat(sChars);
    }
}