1public class Solution 
2{
3    public int MaxProduct(int n) 
4    {
5        int Result = 0;
6        List<int> Digits = new List<int>();
7
8        while(n > 0)
9        {
10            Digits.Add(n % 10);
11            n /= 10;
12        }
13
14        Digits.Sort();
15        Digits.Reverse();
16        //Digits = Digits.OrderByDescending(X => X).ToList();
17
18        Result = Digits[0] * Digits[1];
19
20        return Result;
21    }
22}