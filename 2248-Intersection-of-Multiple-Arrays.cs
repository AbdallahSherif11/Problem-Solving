1public class Solution 
2{
3    public IList<int> Intersection(int[][] nums) 
4    {
5        List<int> result = new List<int>();
6
7        for (int j = 0; j < nums[0].Length; j++)
8        {
9            result.Add(nums[0][j]);
10        }
11
12        for (int i = 0; i < nums.Length; i++)
13        {
14            for (int j = 0; j < nums[i].Length; j++)
15            {
16                result = result.Intersect(nums[i]).ToList();
17            }
18        }
19        result.Sort();
20        
21        return result;
22    }
23}
