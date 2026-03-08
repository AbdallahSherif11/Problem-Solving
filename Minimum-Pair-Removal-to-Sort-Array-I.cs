1public class Solution 
2{
3    public int MinimumPairRemoval(int[] nums)
4    {
5        int Result = 0;
6
7        while (StillDecreasing(nums))
8        {
9            List<int> pairSums = new List<int>();
10            for (int i = 0; i < nums.Length - 1; i++)
11            {
12                pairSums.Add(nums[i] + nums[i + 1]);
13            }
14
15            int minSum = pairSums.Min();
16            int minIndex = pairSums.IndexOf(minSum);
17
18            nums[minIndex] = minSum;
19            var newNums = new List<int>(nums);
20            newNums.RemoveAt(minIndex + 1);
21            nums = newNums.ToArray();
22
23            Result++;
24        }
25
26        return Result;
27    }
28    public bool StillDecreasing(int[] nums)
29    {
30        for (int i = 0; i < nums.Length - 1; i++)
31        {
32            if (nums[i] > nums[i + 1]) return true;
33        }
34        return false;
35    }
36}