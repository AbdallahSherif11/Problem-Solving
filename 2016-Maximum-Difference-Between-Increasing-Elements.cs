1public class Solution 
2{
3    public int MaximumDifference(int[] nums) 
4    {
5        List<int> Candidates = new List<int>();
6
7        for(int i = 0; i < nums.Length; i++)
8        {
9            for(int j = i + 1; j < nums.Length; j++)
10            {
11                if (nums[i] < nums[j])
12                {
13                    Candidates.Add(nums[j] - nums[i]);
14                }
15            }
16        }
17
18        if(Candidates.Count == 0)
19        {
20            return -1;
21        }
22
23        return Candidates.Max();
24    }
25}
