1public class Solution 
2{
3    public string GreatestLetter(string s) 
4    {
5        string Result = "";
6        char[] CharArr = s.ToCharArray();
7        Array.Sort(CharArr);
8
9        for (int i = 0; i < CharArr.Length; i++)
10        {
11            if(CharArr[i] < 97)
12            {
13                if (CharArr.Where(X=> X - CharArr[i] == 32).Count() > 0)
14                {
15                    Result = $"{CharArr[i]}";
16                }
17            }
18            else
19            {
20                break;
21            }
22        }
23        
24        return Result;
25    }
26}