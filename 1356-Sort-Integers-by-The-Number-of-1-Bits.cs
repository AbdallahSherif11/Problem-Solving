1public class Solution 
2{
3    public int[] SortByBits(int[] arr) 
4    {
5        List<int> Result = new List<int>();
6        Dictionary<int,List<int>> Frequency = new Dictionary<int,List<int>>();
7        int Temp = 0;
8        for(int i = 0; i < arr.Length; i++)
9        {
10            Temp = Convert.ToString(arr[i], 2).Count(X => X == '1');
11            if (!Frequency.ContainsKey(Temp))
12            {
13                Frequency.Add(Temp, new List<int>());
14            }
15            Frequency[Temp].Add(arr[i]);
16        }
17
18        var SortedDictionaroy = Frequency.OrderBy(x => x.Key);
19        foreach(var item in SortedDictionaroy)
20        {
21            item.Value.Sort();
22            Result.AddRange(item.Value);
23        }
24
25        return Result.ToArray();
26    }
27}
