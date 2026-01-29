1public class Solution 
2{
3    public IList<int> FindMissingElements(int[] nums) 
4    {
5        List<int> Answer = new List<int>();
6        int Min = nums.Min();
7        int Max = nums.Max();
8
9        List<int> AllNumbersInTheRange = Enumerable.Range(Min, Max-Min).ToList();
10        Answer = AllNumbersInTheRange.Except(nums).ToList();
11
12        return Answer;
13    }
14}