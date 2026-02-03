1public class Solution 
2{
3    public int SumDivisibleByK(int[] nums, int k) 
4    {
5        int Result = 0;
6        Dictionary<int,int> Freq = new Dictionary<int,int>();
7
8        for (int i = 0; i < nums.Length; i++)
9        {
10            if (Freq.ContainsKey(nums[i]))
11            {
12                Freq[nums[i]]++;
13            }
14            else
15            {
16                Freq.Add(nums[i], 1);
17            }
18        }
19
20        foreach (var X in Freq)
21        {
22            if(X.Value % k == 0)
23            {
24                Result += (X.Key * X.Value);
25            }
26        }
27
28        return Result;
29    }
30}