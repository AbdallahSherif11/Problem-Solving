1public class Solution 
2{
3    public int NumberOfSpecialChars(string word) 
4    {
5        char[] WordAsCharArr = word.ToCharArray().Distinct().ToArray();
6        int Result = 0;
7
8        foreach(char c in WordAsCharArr)
9        {
10            if(char.IsLower(c) && WordAsCharArr.Contains(char.ToUpper(c)) || char.IsUpper(c) && WordAsCharArr.Contains(char.ToLower(c)))
11            {
12                Result++;
13            }
14        }
15
16        return Result / 2;
17    }
18}
