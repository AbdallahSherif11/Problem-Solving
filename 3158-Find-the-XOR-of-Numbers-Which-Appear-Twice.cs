1public class Solution 
2{
3    public int DuplicateNumbersXOR(int[] nums) 
4    {
5        List<int> Twice = new List<int>();
6        for (int i  = 0; i < nums.Length; i++)
7        {
8            if(nums.Count(X => X == nums[i]) == 2)
9            {
10                Twice.Add(nums[i]);
11            }
12        }
13        Twice = Twice.Distinct().ToList();
14
15        if (Twice.Count() == 0) return 0;
16
17        int Result = Twice[0];
18
19        for (int i = 1; i < Twice.Count(); i++)
20        {
21            Result ^= Twice[i];
22        }
23
24        return Result;
25    }
26}
