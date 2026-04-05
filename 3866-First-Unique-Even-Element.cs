1public class Solution 
2{
3    public int FirstUniqueEven(int[] nums) 
4    {
5        for(int i = 0; i < nums.Length; i++)
6        {
7            if (nums[i] % 2 == 0)
8            {
9                if(nums.Count(X => X == nums[i]) == 1)
10                {
11                    return nums[i];
12                }
13            }
14        }
15
16        return -1;
17    }
18}
