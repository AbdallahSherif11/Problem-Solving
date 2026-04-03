1public class Solution 
2{
3    public int ReverseBits(int n) 
4    {
5        char[] NBinary = Convert.ToString(n, 2).PadLeft(32, '0').ToCharArray();
6        string Temp = "";
7
8        Array.Reverse(NBinary);
9        Temp = new string(NBinary);
10
11        int Result = Convert.ToInt32(Temp, 2);
12        return Result;
13    }
14}