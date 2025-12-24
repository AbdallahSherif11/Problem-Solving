1public class Solution 
2{
3    public int TotalNumbers(int[] digits) 
4    {
5        List<int> Result = new List<int>();
6        int Temp = 0;
7
8        for(int i = 0; i < digits.Length; i++)
9        {
10            if (digits[i] == 0) continue;
11            for(int j = 0; j < digits.Length; j++)
12            {
13                if(i == j) continue;
14                for (int k = 0; k < digits.Length; k++)
15                {
16                    if (k == j || k == i) continue;
17                    Temp = int.Parse($"{digits[i]}{digits[j]}{digits[k]}");
18                    if (Temp % 2 == 0)
19                    {
20                        Result.Add(Temp);
21                    }
22                }
23            }
24        }
25
26        return Result.Distinct().Count();
27    }
28}
