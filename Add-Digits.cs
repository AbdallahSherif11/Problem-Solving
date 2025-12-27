1public class Solution 
2{
3    public int AddDigits(int num) 
4    {
5        if (num == 0)
6        {
7            return 0;
8        }
9        int Temp = num % 9;
10        if (Temp != 0)
11        {
12            return Temp;
13        }
14
15        return 9;
16    }
17}