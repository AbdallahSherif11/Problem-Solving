1public class Solution 
2{
3    public int[] DecompressRLElist(int[] nums) 
4    {
5        int i = 0;
6        List<int> Result = new List<int>();
7        while(i < nums.Length)
8        {
9            for(int j = 0; j < nums[i];  j++)
10            {
11                Result.Add(nums[i+1]);
12            }
13            i += 2;
14        }
15
16        return Result.ToArray();
17    }
18}