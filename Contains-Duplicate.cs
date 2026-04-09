1public class Solution 
2{
3    public bool ContainsDuplicate(int[] nums) 
4    {
5        List<int> Nums = nums.ToList();
6        List<int> DistinctNums = nums.Distinct().ToList();
7
8        if(Nums.Count == DistinctNums.Count)
9        {
10            return false;
11        }
12
13        return true;
14    }
15}