1public class Solution 
2{
3    public bool IsAnagram(string s, string t) 
4    {
5        char[] sChars = s.ToCharArray();
6        char[] tChars = t.ToCharArray();
7
8        Array.Sort(sChars);
9        Array.Sort(tChars);
10
11        string sOneWord = new string(sChars);
12        string tOneWord = new string(tChars);
13
14        return sOneWord == tOneWord;
15    }
16}