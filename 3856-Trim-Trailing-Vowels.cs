1public class Solution 
2{
3    public string TrimTrailingVowels(string s) 
4    {
5        string Result = s;
6
7        while(Result.EndsWith('a') || Result.EndsWith('e') || Result.EndsWith('i') || Result.EndsWith('o') || Result.EndsWith('u'))
8        {
9            Result = Result.Substring(0, Result.Length - 1);
10        }
11
12        return Result;
13    }
14}
