1public class Solution 
2{
3    public int FirstUniqChar(string s) 
4    {
5        int Result = -1;
6
7        char[] chars = s.Distinct().Where(X => s.Count(c => c == X) == 1).ToArray();
8        if(chars.Length > 0)
9        {
10            Result = s.IndexOf(chars[0]);
11        }
12
13        return Result;
14    }
15}
