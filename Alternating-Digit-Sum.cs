1public class Solution 
2{
3    public int AlternateDigitSum(int n) 
4    {
5        int Result = 0;
6        string Temp = n.ToString();
7        char[] digits = Temp.ToCharArray();
8
9        for(int i = 0; i < digits.Length; i++)
10        {
11            if(i % 2 == 0)
12            {
13                Result += (int)char.GetNumericValue(digits[i]);
14            }
15            else
16            {
17                Result += -1 * (int)char.GetNumericValue(digits[i]);
18            }
19        }
20
21        return Result;
22    }
23}