1public class Solution 
2{
3    public int MinimumDistance(int[] nums) 
4    {
5        int Result = int.MaxValue;
6        bool flag = true;
7        int Temp = 0;
8        List<int> DistinctNums = nums.Distinct().ToList();
9
10        foreach (int num in DistinctNums)
11        {
12            if(nums.Count(X => X == num) >= 3)
13            {
14                flag = false; // at least one numbers exists three times in the array
15                break;
16            }
17        }
18        if (flag)
19        {
20            return -1;
21        }
22
23        for(int i = 0; i < nums.Length - 2; i++)
24        {
25            for(int j = i+1; j < nums.Length - 1; j++)
26            {
27                for(int k = j+1; k < nums.Length; k++)
28                {
29                    if(nums[i] == nums[j] && nums[j] == nums[k])
30                    {
31                        Temp = Math.Abs(i - j) + Math.Abs(j - k) + Math.Abs(i - k);
32                        if(Temp < Result)
33                        {
34                            Result = Temp;
35                        }
36                    }
37                }
38            }
39        }
40
41        return Result;
42    }
43}