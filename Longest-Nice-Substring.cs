1public class Solution 
2{
3    public string LongestNiceSubstring(string s) 
4    {
5        string Result = "";
6        string Temp = "";
7        bool flag = false;
8
9        for(int i = 0; i < s.Length - 1; i++)
10        {
11            for(int j = 1; j <= s.Length - i; j++)
12            {
13                Temp = s.Substring(i, j);
14                flag = true;
15                foreach(char c in Temp)
16                {
17                    if (!Temp.Contains(char.ToUpper(c)) || !Temp.Contains(char.ToLower(c)))
18                    {
19                        flag = false;
20                        break;
21                    }
22                }
23                if (flag == true && Temp.Length > 1 && Temp.Length > Result.Length )
24                {
25                    Result = Temp;
26                }
27            }
28        }
29
30        return Result;
31    }
32}