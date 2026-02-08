1public class Solution 
2{
3    public int MinimumPushes(string word) 
4    {
5        int Result = 0;
6
7        if (word.Length <= 8)
8        {
9            Result = word.Length;
10        }
11        else if (word.Length <= 16)
12        {
13            Result = 8 + (word.Length - 8) * 2;
14        }
15        else if(word.Length <= 24)
16        {
17            Result = 24 + (word.Length - 16) * 3;
18        }
19        else
20        {
21            Result = 48 + (word.Length - 24) * 4;
22        }
23
24        return Result;
25    }
26}