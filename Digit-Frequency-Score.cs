1public class Solution 
2{
3    public int DigitFrequencyScore(int n) 
4    {
5        double Result = 0;
6        string N = n.ToString();
7        foreach(char c in N)
8        {
9            Result += char.GetNumericValue(c);
10        }
11
12
13        return (int)Result;
14    }
15}