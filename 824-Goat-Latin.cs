1public class Solution 
2{
3    public string ToGoatLatin(string sentence) 
4    {
5        string Result = "";
6        char[] Vowels = ['a', 'A', 'e', 'E', 'o', 'O', 'u', 'U', 'i', 'I'];
7
8        string[] Temp = sentence.Split(' ');
9        for (int i = 0; i < Temp.Length; i++)
10        {
11            if (Vowels.Contains(Temp[i][0]))
12            {
13                Result += Temp[i];
14            }
15            else
16            {
17                for (int j = 1; j < Temp[i].Length; j++)
18                {
19                    Result += Temp[i][j];
20                }
21                Result += Temp[i][0];
22            }
23            Result += "ma";
24            for (int k = 0; k < i+1; k++)
25            {
26                Result += 'a';
27            }
28            Result += ' ';
29        }
30
31        return Result.Trim();
32    }
33}
