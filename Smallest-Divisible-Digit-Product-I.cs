1public class Solution 
2{
3    public int SmallestNumber(int n, int t) 
4    {
5        int Result = 0;
6        int Temp = 1;
7        string N = n.ToString();
8
9        for (int i = n; i < int.MaxValue; i++)
10        {
11            Temp = 1;
12            N = i.ToString();
13            foreach (char c in N)
14            {
15                Temp *= (int)char.GetNumericValue(c);
16            }
17            if(Temp % t == 0)
18            {
19                return i;
20            }
21        }
22
23        return Result;
24    }
25}