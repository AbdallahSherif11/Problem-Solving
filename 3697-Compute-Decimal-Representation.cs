1public class Solution 
2{
3    public int[] DecimalRepresentation(int n) 
4    {
5        string Temp = n.ToString();
6        List<int> Result = new List<int>();
7        int j = 0;
8        int Current = 0;
9
10        for(int i = Temp.Length - 1; i >= 0; i--)
11        {
12            Current = (int)Char.GetNumericValue(Temp[i]) * (int)Math.Pow(10, j);
13            if(Current != 0)
14            {
15                Result.Add(Current);
16            }
17            j++;
18        }
19        Result.Sort();
20        Result.Reverse();
21
22        return Result.ToArray();
23    }
24}
