1public class Solution 
2{
3    public string GetEncryptedString(string s, int k) 
4    {
5        string Result = "";
6
7        int Temp = k % s.Length;
8        int X = 0;
9
10        for (int i = 0; i < s.Length; i++)
11        {
12            if(Temp + i >= s.Length)
13            {
14                X = Temp + i - s.Length;
15            }
16            else
17            {
18                X = Temp + i;
19            }
20            Result += s[X];
21        }
22
23        return Result;
24    }
25}