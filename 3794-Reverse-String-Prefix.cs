1public class Solution 
2{
3    public string ReversePrefix(string s, int k) 
4    {
5        char[] FirstPart = s.Substring(0, k).ToArray();
6        string FirstPartReversed = new string(FirstPart.Reverse().ToArray());
7
8        string Result = $"{FirstPartReversed}{s.Substring(k)}";
9
10        return Result;
11    }
12}
