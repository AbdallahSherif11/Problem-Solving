1public class Solution 
2{
3    public int ResiduePrefixes(string s) 
4    {
5        int Result = 0;
6        string temp = "";
7
8        for (int i  = 0; i < s.Length; i++)
9        {
10            temp = s.Substring(0, i + 1);
11            if (temp.Length % 3 == temp.Distinct().Count())
12            {
13                Result++;
14            }
15        }
16
17        return Result;
18    }
19}
