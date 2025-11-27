1public class Solution 
2{
3    public int[] ArrayRankTransform(int[] arr) 
4    {
5        int[] Temp = new int[arr.Length];
6        Temp = (int[])arr.Clone();
7        int[] Result = new int[arr.Length];
8        Dictionary<int,int> X = new Dictionary<int,int>();
9
10        Array.Sort(Temp);
11        int k = 1;
12        foreach(int i in Temp)
13        {
14            if (X.ContainsKey(i))
15            {
16
17            }
18            else
19            {
20                X.Add(i, k);
21                k++;
22            }
23        }
24        for(int i = 0; i < arr.Length; i++)
25        {
26            Result[i] = X[arr[i]];
27        }
28
29        return Result;
30    }
31}