1public class Solution 
2{
3    public int FirstMatchingIndex(string s) 
4    {
5        int Result = -1;
6        int n = s.Length;
7
8        for(int i = 0; i < s.Length; i++)
9        {
10            if (s[i] == s[n - i - 1])
11            {
12                return i;
13            }
14        }
15
16        return Result;
17    }
18}
