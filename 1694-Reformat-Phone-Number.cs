1public class Solution 
2{
3    public string ReformatNumber(string number) 
4    {
5        string Temp = number.Replace(" ", "");
6        Temp = Temp.Replace("-", "");
7        string Result = "";
8
9        if(Temp.Length <= 4)
10        {
11            if (Temp.Length == 2)
12            {
13                return Temp;
14            }
15            else if (Temp.Length == 3)
16            {
17                return Temp;
18            }
19            else if (Temp.Length == 4)
20            {
21                return $"{Temp.Substring(0, 2)}-{Temp.Substring(2)}";
22            }
23        }
24
25        while(Temp.Length > 3)
26        {
27            Result = $"{Result}{Temp.Substring(0, 3)}";
28            Temp = Temp.Substring(3);
29            if(Temp.Length <= 4)
30            {
31                if(Temp.Length == 2)
32                {
33                    Result = $"{Result}-{Temp.Substring(0, 2)}";
34                    Temp = Temp.Substring(2);
35                }
36                else if (Temp.Length == 3)
37                {
38                    Result = $"{Result}-{Temp.Substring(0, 3)}";
39                    Temp = Temp.Substring(3);
40                }
41                else if(Temp.Length == 4)
42                {
43                    Result = $"{Result}-{Temp.Substring(0, 2)}-{Temp.Substring(2)}";
44                    Temp = Temp.Substring(4);
45                }
46            }
47            else 
48            {
49                Result = $"{Result}-";
50            }
51        }
52
53
54        return Result;
55    }
56}
