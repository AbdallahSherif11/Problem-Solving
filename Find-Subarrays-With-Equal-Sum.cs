1public class Solution 
2{
3    public bool FindSubarrays(int[] nums) 
4    {
5        bool Result = false;
6        List<int> Sums = new List<int>();
7        Sums.Add(nums[0]+ nums[1]);
8        for(int i  = 1; i < nums.Length - 1; i++)
9        {
10            Sums.Add(nums[i] + nums[i+1]);
11        }
12
13        if(Sums.Count > Sums.Distinct().ToArray().Count())
14        {
15            Result = true;
16        }
17
18        return Result;
19    }
20}