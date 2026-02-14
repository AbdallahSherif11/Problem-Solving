1public class Solution 
2{
3    public int CountBinarySubstrings(string s) 
4    {
5        int Result = 0;
6        string Temp1 = "";
7        string Temp2 = "";
8        int Count1 = 0;
9        int Count2 = 0;
10        char Current = s[0];
11        char Opposite = Current == '1' ? '0' : '1';
12
13        if (s.Length < 2)
14        {
15            return 0;
16        }
17
18        for(int i = 0; i < s.Length - 1; i++)
19        {
20            if (s[i + 1] == s[i])
21            {
22                Current = s[i];
23                Opposite = Current == '1' ? '0' : '1';
24
25                Temp1 = s.Substring(i, s.Substring(i + 1).IndexOf(Opposite) + 1);
26                Count1 = Temp1.Length;
27                if (i + Count1 + Count1 > s.Length)
28                {
29                    continue;
30                }
31                Temp2 = s.Substring(i + Count1, Count1);
32                //Count2 = Temp2.Count(x => x == Opposite);
33
34                if (!Temp2.Contains(Current) && Temp2 != "")
35                {
36                    Result++;
37                }
38            }
39            else
40            {
41                Result++;
42            }
43        }
44
45        return Result;
46    }
47}
