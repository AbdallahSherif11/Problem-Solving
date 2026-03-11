1public class Solution 
2{
3    public int MaxScore(string s) 
4    {
5        List<int> ScoreList = new List<int>(500);
6        int AllOnes = s.Count(X => X == '1');
7        int CountZeros = 0;
8        
9        for(int i = 0; i < s.Length - 1; i++)
10        {
11            CountZeros = s.Substring(0, i+1).Count(X => X == '0');
12            ScoreList.Add(AllOnes + CountZeros - (i + 1 - CountZeros));
13        }
14
15
16        return ScoreList.Max();
17    }
18}
