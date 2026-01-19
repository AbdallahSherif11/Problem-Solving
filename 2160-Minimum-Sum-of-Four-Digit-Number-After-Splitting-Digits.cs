1public class Solution 
2{
3    public int MinimumSum(int num) 
4    {
5        char[] Temp = num.ToString().ToArray();
6        Array.Sort(Temp);
7        double Result = char.GetNumericValue(Temp[0]) * 10 + char.GetNumericValue(Temp[1]) * 10 + char.GetNumericValue(Temp[2]) + char.GetNumericValue(Temp[3]);
8
9        return (int)Result;
10    }
11}
