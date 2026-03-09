1public class Solution 
2{
3    public bool RotateString(string s, string goal) 
4    {
5        if(s == goal)
6        {
7            return true;
8        }
9        if(s.Length == 1)
10        {
11            return false;
12        }
13
14        for(int i  = 0; i < s.Length; i++)
15        {
16            s = $"{s.Substring(1, s.Length - 1)}{s[0]}";
17            if(s == goal)
18            {
19                return true;
20            }
21        }
22
23        return false;
24    }
25}