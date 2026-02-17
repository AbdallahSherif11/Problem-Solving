1public class Solution 
2{
3    public bool IsSubstringPresent(string s) 
4    {
5        bool Result = false;
6        string reversedS = new string(s.Reverse().ToArray());   
7
8        List<string> Subs1 = new List<string>();
9        List<string> Subs2 = new List<string>();
10        for(int i = 0; i < s.Length -1; i++)
11        {
12            Subs1.Add(s.Substring(i, 2));
13            Subs2.Add(reversedS.Substring(i, 2));
14        }
15
16        if(Subs1.Intersect(Subs2).Count() > 0)
17        {
18            Result = true;
19        }
20
21        return Result;
22    }
23}
