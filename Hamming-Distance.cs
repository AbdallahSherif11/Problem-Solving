1public class Solution 
2{
3    public int HammingDistance(int x, int y) 
4    {
5        int Result = 0;
6
7        string X = Convert.ToString(y, 2).PadLeft(32, '0');
8        string Y = Convert.ToString(x, 2).PadLeft(32, '0');
9
10        for(int i = 0; i < X.Length; i++)
11        {
12            if (X[i] != Y[i])
13            {
14                Result++;
15            }
16        }
17
18        return Result;
19    }
20}