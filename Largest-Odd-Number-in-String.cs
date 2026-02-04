1public class Solution 
2{
3    public string LargestOddNumber(string num) 
4    {
5        string Result = "";
6
7        for (int i = num.Length - 1; i >= 0; i--)
8        {
9            if (char.GetNumericValue(num[i]) % 2 == 1)
10            {
11                Result = num.Substring(0, i+1);
12                break;
13            }
14        }
15
16        return Result;
17    }
18}