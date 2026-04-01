1public class Solution 
2{
3    public bool CheckAlmostEquivalent(string word1, string word2) 
4    {
5        bool Result = true;
6
7        char[] CheckChars = word1.Distinct().Union(word2.Distinct()).ToArray();
8        for(int i = 0; i < CheckChars.Length; i++)
9        {
10            if(Math.Abs(word1.Count(X => X == CheckChars[i]) - word2.Count(Y => Y == CheckChars[i]))  > 3)
11            {
12                return false;
13            }
14        }
15
16        return Result;
17    }
18}
