1public class Solution 
2{
3    public int MinOperations(string s) 
4    {
5        int Count1 = 0; // 101010
6        int Count2 = 0; // 010101
7
8        for(int i = 0; i < s.Length; i++)
9        {
10            if(i % 2 == 0)
11            {
12                if (s[i] == '1')
13                {
14                    Count2++;
15                }
16                else
17                {
18                    Count1++;
19                }
20            }
21            else
22            {
23                if (s[i] == '1')
24                {
25                    Count1++;
26                }
27                else
28                {
29                    Count2++;
30                }
31            }
32        }
33
34        return Count1 <= Count2 ? Count1 : Count2;
35    }
36}