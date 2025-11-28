1public class Solution 
2{
3    public int FindComplement(int num) 
4    {
5        int Result = 0;
6
7        string Temp = Convert.ToString(num, 2).Replace('1', 'x').Replace('0', '1').Replace('x', '0');
8        Result = Convert.ToInt32(Temp, 2);
9
10        return Result;
11    }
12}
