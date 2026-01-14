1public class Solution 
2{
3    public string DigitSum(string s, int k) 
4    {
5        string Temp = "";
6        if(s.Length <= k)
7        {
8            return s;
9        }
10        int x = 0;
11        int y = 0;
12        int i = 0;
13        int j = 0;
14        double TempCalc = 0;
15        while(s.Length > k)
16        {
17            x = s.Length % k;
18            y = s.Length / k;
19
20            for(i = 0; i < y; i++)
21            {
22                for(j = i * k; j < (i+1) * k; j++)
23                {
24                    TempCalc += (int)char.GetNumericValue(s[j]);
25                }
26                Temp += TempCalc.ToString();
27                TempCalc = 0;
28            }
29            if(x > 0)
30            {
31                for (int L = j; L < j+x; L++)
32                {
33                    TempCalc += (int)char.GetNumericValue(s[L]);
34                }
35                Temp += TempCalc.ToString();
36            }
37            TempCalc = 0;
38            s = Temp;
39            Temp = "";
40        }
41        return s;
42    }
43}
