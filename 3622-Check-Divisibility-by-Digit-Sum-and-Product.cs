1public class Solution 
2{
3    public bool CheckDivisibility(int n) 
4    {
5        int Temp = n;
6
7        List<int> Digits = new List<int>();
8        while(Temp > 0)
9        {
10            Digits.Add(Temp % 10);
11            Temp /= 10;
12        }
13        int Sum = Digits.Sum();
14        int Multi = 1;
15        for(int i = 0; i < Digits.Count; i++)
16        {
17            Multi *= Digits[i];
18        }
19        if(n % (Multi + Sum) == 0)
20        {
21            return true;
22        }
23
24        return false;
25    }
26}
