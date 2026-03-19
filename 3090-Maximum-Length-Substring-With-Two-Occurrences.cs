1public class Solution 
2{
3    public int MaximumLengthSubstring(string s) 
4    {
5        int Result = 1;
6        string Temp = "";
7        bool Flag = true;
8
9        for (int i = 0; i < s.Length - 1; i++)
10        {
11            Temp = "";
12            Flag = true;
13            for (int j = 1; j <= s.Length - i; j++)
14            {
15                Temp = s.Substring(i, j);
16                foreach(char c in Temp)
17                {
18                    if(Temp.Count(X =>  X == c) > 2)
19                    {
20                        Flag = false;
21                        break;
22                    }
23                }
24                if(Flag == false)
25                {
26                    break;
27                }
28                else
29                {
30                    if(Temp.Length > Result)
31                    {
32                        Result = Temp.Length;
33                    }
34                }
35            }
36        }
37
38        return Result;
39    }
40}
