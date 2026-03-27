1public class Solution 
2{
3    public int CountCommas(int n) 
4    {
5        int Result = 0;
6
7        if(n < 1000)
8        {
9            return 0;
10        }
11        else
12        {
13            Result = n - 1000 + 1;
14        }
15
16        return Result;
17    }
18}