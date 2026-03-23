1public class Solution 
2{
3    public int CountTriples(int n) 
4    {
5        int Result = 0;
6        double Temp = 0;
7
8        for(int i = 1; i <= n; i++)
9        {
10            for(int j = 1; j <= n; j++)
11            {
12                Temp = Math.Sqrt(i * i + j * j);
13                if (Temp % 1 == 0)
14                {
15                    if(Temp <= n)
16                    {
17                        Result++;
18                    }
19                }
20            }
21        }
22
23        return Result;
24    }
25}
