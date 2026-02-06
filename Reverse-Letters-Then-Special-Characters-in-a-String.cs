1public class Solution 
2{
3    public string ReverseByType(string s) 
4    {
5        string Result = "";
6        char[] ResultArray = s.ToCharArray();
7
8        Stack<char> chars = new Stack<char>();
9        Stack<char> SpecialChars = new Stack<char>();
10
11        for (int i = 0; i < s.Length; i++)
12        {
13            if (char.IsLetter(s[i]))
14            {
15                chars.Push(s[i]);
16            }
17            else
18            {
19                SpecialChars.Push(s[i]);
20            }
21        }
22
23        for(int i = 0; i < s.Length; i++)
24        {
25            if (char.IsLetter(s[i]))
26            {
27                ResultArray[i] = chars.Pop();
28            }
29            else
30            {
31                ResultArray[i] = SpecialChars.Pop();
32            }
33        }
34
35        Result = new string(ResultArray);
36
37        return Result;
38    }
39}