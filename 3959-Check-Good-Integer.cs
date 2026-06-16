1public class Solution 
2{
3    public bool CheckGoodInteger(int n) 
4    {
5        double digitSum = 0;
6        double squareSum = 0;
7        string Nstring = n.ToString();
8
9        foreach(char c in Nstring)
10        {
11            digitSum += char.GetNumericValue(c);
12            squareSum += Math.Pow(char.GetNumericValue(c), 2);
13        }
14
15        return squareSum - digitSum >= 50;
16    }
17}
