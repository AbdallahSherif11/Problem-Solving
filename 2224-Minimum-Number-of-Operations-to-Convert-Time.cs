1public class Solution 
2{
3    public int ConvertTime(string current, string correct) 
4    {
5        int Result = 0;
6
7        int CurrentInMinutes = int.Parse(current.Substring(0, 2)) * 60 + int.Parse(current.Substring(3, 2));
8        int CorrectInMinutes = int.Parse(correct.Substring(0, 2)) * 60 + int.Parse(correct.Substring(3, 2));
9
10        int Difference = CorrectInMinutes - CurrentInMinutes;
11
12        while (Difference != 0)
13        {
14            if(Difference >= 60)
15            {
16                Difference -= 60;
17                Result++;
18            }
19            else if (Difference >= 15)
20            {
21                Difference -= 15;
22                Result++;
23            }
24            else if (Difference >= 5)
25            {
26                Difference -= 5;
27                Result++;
28            }
29            else if (Difference >= 1)
30            {
31                Difference -= 1;
32                Result++;
33            }
34        }
35
36        return Result;
37    }
38}
