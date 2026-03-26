1public class Solution 
2{
3    public int SumBase(int n, int k) 
4    {
5        int Result = 0;
6        string N = "";
7        
8        while (n > 0)
9        {
10            N = $"{(n % k).ToString()}{N}";
11            n /= k;
12        }
13        for(int i = 0; i < N.Length; i++)
14        {
15            Result += (int)char.GetNumericValue(N[i]);
16        }
17
18        return Result;
19    }
20}