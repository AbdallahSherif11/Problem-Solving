1public class Solution 
2{
3    public double CalculateTax(int[][] brackets, int income) 
4    {
5        double Result = 0;
6        double Temp = 0;
7        if (income == 0) return 0;
8
9        if (income >= brackets[0][0])
10        {
11            Result += brackets[0][0] * (brackets[0][1] / (double)100);
12            income -= brackets[0][0];
13        }
14        else
15        {
16            Result += income * (brackets[0][1] / (double)100);
17            income -= brackets[0][0];
18        }
19        for (int i = 1; i < brackets.Length && income > 0; i++)
20        {
21            Temp = brackets[i][0] - brackets[i-1][0];
22            if(income >= Temp)
23            {
24                Result += Temp * (brackets[i][1] / (double)100);
25                income -= (int)Temp;
26            }
27            else
28            {
29                Result += income * (brackets[i][1] / (double)100);
30                income -= (int)Temp;
31            }
32        }
33
34        return Result;
35    }
36}
