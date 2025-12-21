1public class Solution 
2{
3    public int IsPrefixOfWord(string sentence, string searchWord) 
4    {
5        string[] Words = sentence.Split(' ');
6        for(int i = 0; i < Words.Length; i++)
7        {
8            if (Words[i].StartsWith(searchWord))
9            {
10                return i+1;
11            }
12        }
13
14        return -1;
15    }
16}
