1public class Solution 
2{
3    public int LongestMonotonicSubarray(int[] nums) 
4    {
5        int Result = 1;
6        List<List<int>> IncreasingLists = new List<List<int>>();
7        List<List<int>> DecreasingLists = new List<List<int>>();
8
9        for (int i = 0; i < nums.Length - 1; i++)
10        {
11            for(int j = i+1; j < nums.Length; j++)
12            {
13                if (nums[j] > nums[j-1])
14                {
15                    IncreasingLists.Add(nums.Take(i..(j+1)).ToList());
16                    if(j - i + 1 > Result)
17                    {
18                        Result = j - i + 1;
19                    }
20                }
21                else
22                {
23                    break;
24                }
25                
26            }
27        }
28        for (int i = 0; i < nums.Length - 1; i++)
29        {
30            for (int j = i + 1; j < nums.Length; j++)
31            {
32                if (nums[j] < nums[j - 1])
33                {
34                    DecreasingLists.Add(nums.Take(i..(j + 1)).ToList());
35                    if (j - i + 1 > Result)
36                    {
37                        Result = j - i + 1;
38                    }
39                }
40                else
41                {
42                    break;
43                }
44
45            }
46        }
47
48        return Result;
49    }
50}