1public class Solution 
2{
3    public int MinimumFlips(int n) 
4    {
5        int Result = 0;
6        string NBinary = Convert.ToString(n, 2);
7        char[] NBinaryArr = NBinary.ToArray();
8        char[] Reversed = NBinary.ToArray();
9        Array.Reverse(Reversed);
10
11        for (int i = 0; i < NBinaryArr.Length; i++)
12        {
13            if(NBinaryArr[i] != Reversed[i])
14            {
15                Result++;
16            }
17        }
18
19        return Result;
20    }
21}
