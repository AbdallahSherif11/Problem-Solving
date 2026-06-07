1public class Solution 
2{
3    public int[] ConcatWithReverse(int[] nums) 
4    {
5        List<int> Result = new List<int>();
6
7        Result.AddRange(nums);
8        Array.Reverse(nums);
9        Result.AddRange(nums);
10
11        return Result.ToArray();
12    }
13}