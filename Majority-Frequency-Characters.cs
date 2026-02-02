1public class Solution 
2{
3    public string MajorityFrequencyGroup(string s) 
4    {
5        string Result = "";
6        char[] chars = s.ToCharArray().Distinct().ToArray();
7        int cout = 0;
8        int MaxLength = 1;
9        int MaxFreq = 1;
10
11        Dictionary<int,List<char>> Temp = new Dictionary<int,List<char>>();
12
13        foreach (char c in chars)
14        {
15            cout = s.Count(X => X == c);
16
17            if (Temp.ContainsKey(cout))
18            {
19                Temp[cout].Add(c);
20                if (Temp[cout].Count > MaxLength)
21                {
22                    MaxLength = Temp[cout].Count;
23                }
24            }
25            else
26            {
27                Temp.Add(cout, new List<char>());
28                Temp[cout].Add(c);
29            }
30        }
31
32        foreach(var X in Temp)
33        {
34            if(X.Value.Count == MaxLength)
35            {
36                if(X.Key >= MaxFreq)
37                {
38                    MaxFreq = X.Key;
39                    Result = new string(X.Value.ToArray());
40                }
41            }
42        }
43
44        return Result;
45    }
46}