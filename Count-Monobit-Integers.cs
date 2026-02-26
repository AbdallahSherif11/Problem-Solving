1public class Solution 
2{
3    public int CountMonobit(int n) 
4    {
5        int Result = 0;
6        string Temp = "";
7        char FirstChar = '\0';
8
9        for (int i = 0; i <= n; i++)
10        {
11            Temp = Convert.ToString(i, 2);
12            FirstChar = Temp[0];
13            if(Temp.Length == Temp.Count(X => X == FirstChar))
14            {
15                Result++;
16            }
17        }
18
19        return Result;
20    }
21}