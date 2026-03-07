1public class Solution 
2{
3    public int[] MinDistinctFreqPair(int[] nums) 
4    {
5        int[] Result = new int[2];
6        Array.Sort(nums);
7        Dictionary<int,int> Frequency = new Dictionary<int,int>();
8        int i = 0;
9        for(i = 0; i < nums.Length; i++)
10        {
11            if (Frequency.ContainsKey(nums[i]))
12            {
13                Frequency[nums[i]]++;
14            }
15            else
16            {
17                Frequency.Add(nums[i], 1);
18            }
19        }
20        Result[0] = Frequency.First().Key;
21        i = 1;
22        for(i = 1; i < nums.Length; i++)
23        {
24            if (Frequency[nums[i]] != Frequency.First().Value)
25            {
26                Result[1] = nums[i];
27                break;
28            }
29        }
30        if(i == nums.Length)
31        {
32            Result = [-1, -1];
33        }
34
35        return Result;
36    }
37}