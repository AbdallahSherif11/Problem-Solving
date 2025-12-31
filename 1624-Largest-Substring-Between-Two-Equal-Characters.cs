1public class Solution 
2{
3    public int MaxLengthBetweenEqualCharacters(string s) 
4    {
5        List<int> Result = new List<int>();
6        Result.Add(-1);
7
8        for (int i = 0; i < s.Length - 1; i++)
9        {
10            for(int j = i+1; j < s.Length; j++)
11            {
12                if (s[i] == s[j])
13                {
14                    Result.Add(j - i - 1);
15                }
16            }
17        }
18
19        return Result.Max();
20    }
21}
