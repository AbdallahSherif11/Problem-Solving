1public class Solution 
2{
3    public int MinOperations(int[] nums, int k) 
4    {
5        int Count = 0;
6        int i = 0;
7
8        while(nums.Sum() % k != 0)
9        {
10            if (nums[i] > 0)
11            {
12                nums[i]--;
13                Count++;
14            }
15            else
16            {
17                i++;
18            }
19        }
20
21        return Count;
22    }
23}
