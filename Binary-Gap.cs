1public class Solution 
2{
3    public int BinaryGap(int n) 
4    {
5        int Result = 0;
6        string N = Convert.ToString(n, 2);
7
8        if(N.Count(X => X == '1') >= 2)
9        {
10            for(int i = 0; i < N.Length - 1; i++)
11            {
12                if (N[i] == '1')
13                {
14                    for(int j = i+1; j < N.Length; j++)
15                    {
16                        if(N[j] == '1')
17                        {
18                            if(j - i > Result)
19                            {
20                                Result = j - i;
21                            }
22                            break;
23                        }
24                    }
25                }
26            }
27        }
28
29        return Result;
30    }
31}