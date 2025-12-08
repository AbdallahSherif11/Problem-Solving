1public class Solution 
2{
3    public IList<string> StringMatching(string[] words) 
4    {
5        List<string> Result = new List<string>();
6
7        for (int i = 0; i < words.Length; i++)
8        {
9            for(int j = 0; j < words.Length; j++)
10            {
11                if (i == j) continue;
12                if (words[i].Contains(words[j]))
13                {
14                    Result.Add(words[j]);
15                }
16            }
17        }
18
19        return Result.Distinct().ToList();
20    }
21}