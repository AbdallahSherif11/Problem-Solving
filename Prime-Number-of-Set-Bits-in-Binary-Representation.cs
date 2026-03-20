1public class Solution 
2{
3    public int CountPrimeSetBits(int left, int right) 
4    {
5        int Result = 0;
6        string Temp = "";
7        int[] PossiblePrimesCountInConstraints = [2, 3, 5, 7, 11, 13, 17, 19];
8        int x = 0;
9
10        for (int i = left; i <= right; i++)
11        {
12            Temp = Convert.ToString(i, 2);
13            x = Temp.Count(X => X == '1');
14
15            if (PossiblePrimesCountInConstraints.Contains(x)) 
16            {
17                Result++;
18            }
19            
20        }
21
22        return Result;
23    }
24}