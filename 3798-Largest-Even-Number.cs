1public class Solution 
2{
3    public string LargestEven(string s) 
4    {
5        string Result = "";
6
7        if(!s.Contains('2'))
8        {
9            return Result;
10        }
11
12        Result = s.Substring(0, s.LastIndexOf('2') + 1);
13
14        return Result;
15    }
16}
