1public class Solution 
2{
3    public int RemovePalindromeSub(string s) 
4    {
5        int Result = 0;
6        string sReversed = new string(s.Reverse().ToArray());
7
8        if(sReversed == s)
9        {
10            Result = 1;
11        }
12        else
13        {
14            Result = 2;
15        }
16
17        return Result;
18    }
19}
