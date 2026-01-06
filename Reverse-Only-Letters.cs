1public class Solution 
2{
3    public string ReverseOnlyLetters(string s) 
4    {
5        string Result = "";
6
7        Stack<char> ActualLetters = new Stack<char>();
8
9        char[] ResultArr = new char[s.Length];
10
11        for (int i = 0; i < s.Length; i++)
12        {
13            if (char.IsLetter(s[i]))
14            {
15                ActualLetters.Push(s[i]);
16            }
17        }
18        char Temp = 'a';
19
20        for(int i = 0; i < s.Length; i++)
21        {
22            if (char.IsLetter(s[i]))
23            {
24                Temp = ActualLetters.Pop();
25                ResultArr[i] = Temp;
26            }
27            else
28            {
29                ResultArr[i] = s[i];
30            }
31        }
32
33        Result = new string(ResultArr);
34
35        return Result;
36    }
37}