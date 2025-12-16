1public class Solution 
2{
3    public int CountHillValley(int[] nums) 
4    {
5        int Result = 0;
6        int i = 1;
7        int j = 0;
8        int k = 2;
9        bool isHill = false;
10        bool isValley = false;
11
12        for(i = 1; i < nums.Length-1; i++)
13        {
14            for(j = i-1; j >= 0; j--)
15            {
16                if (nums[j] != nums[i])
17                {
18                    break;
19                }
20            }
21
22            for(k = i+1; k < nums.Length; k++)
23            {
24                if (nums[k] != nums[i])
25                {
26                    break;
27                }
28            }
29            if(j > -1 && k < nums.Length)
30            {
31                if (j != i && k != i)
32                {
33                    if (nums[j] > nums[i] && nums[k] > nums[i] && isValley != true)
34                    {
35                        isHill = false;
36                        isValley = true;
37                        Result++;
38                    }
39                    else if (nums[j] < nums[i] && nums[k] < nums[i] && isHill != true)
40                    {
41                        isValley = false;
42                        isHill = true;
43                        Result++;
44                    }
45                }
46            }
47        }
48
49        return Result;
50    }
51}
