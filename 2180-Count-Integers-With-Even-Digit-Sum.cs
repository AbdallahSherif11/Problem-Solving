1public class Solution 
2{
3    public int CountEven(int num) 
4    {
5        int Result = 0;
6        double Temp = 0;
7        string TempStr = "";
8
9        for (int i = 1; i <= num; i++)
10        {
11            Temp = 0;
12            TempStr = i.ToString();
13            for(int j = 0; j < TempStr.Length; j++)
14            {
15                Temp += char.GetNumericValue(TempStr[j]);
16            }
17            if(Temp % 2  == 0)
18            {
19                Result++;
20            }
21        }
22
23        return Result;
24    }
25}
