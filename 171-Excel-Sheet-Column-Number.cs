1public class Solution 
2{
3    public int TitleToNumber(string columnTitle) 
4    {
5        int Result = 0;
6
7        Dictionary<char, int> CharVal = new Dictionary<char, int>();
8        char charIterator = 'A';
9        for(int i = 1; i <= 26; i++)
10        {
11            CharVal.Add(charIterator, i);
12            charIterator++;
13        }
14
15        for(int i = 0; i < columnTitle.Length; i++)
16        {
17            Result = Result + (int)Math.Pow(26, columnTitle.Length - i - 1) * CharVal[columnTitle[i]];
18        }
19
20        return Result;
21    }
22}
