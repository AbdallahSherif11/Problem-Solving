1public class Solution 
2{
3    public string CapitalizeTitle(string title) 
4    {
5        string Result = "";
6
7        string[] Words = title.Split(' ');
8        for(int i = 0; i < Words.Length; i++)
9        {
10            if (Words[i].Length > 2)
11            {
12                Words[i] = $"{char.ToUpper(Words[i][0])}{Words[i].Substring(1, Words[i].Length - 1).ToLower()}";
13            }
14            else
15            {
16                Words[i] = Words[i].ToLower();
17            }
18        }
19
20        Result = string.Join(' ', Words);
21
22        return Result;
23    }
24}