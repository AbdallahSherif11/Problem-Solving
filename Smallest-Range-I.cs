1public class Solution 
2{
3    public int SmallestRangeI(int[] nums, int k) 
4    {
5        if (nums.Length == 1)
6        {
7            return 0;
8        }
9        int Temp1 = (int)Math.Ceiling(nums.Average());
10        int Average = (int)Math.Ceiling(nums.Average());
11
12        int Temp2 = nums.Min() + k;
13        int Temp3 = nums.Max() - k;
14        if (Temp2 > Average)
15        {
16            Temp2 = Average;
17        }
18        if (Temp3 < Average)
19        {
20            Temp3 = Average;
21        }
22
23        if (Math.Abs(Temp3 - Average) < Math.Abs(Temp2 - Average))
24        {
25            Average = Temp2;
26        }
27        else
28        {
29            Average = Temp3;
30        }
31
32        for (int i = 0; i < nums.Length; i++)
33        {
34            if (Average > nums[i])
35            {
36                nums[i] += k;
37                if (nums[i] > Average)
38                {
39                    nums[i] = Average;
40                }
41            }
42            else if (Average < nums[i])
43            {
44                nums[i] -= k;
45                if (nums[i] < Average)
46                {
47                    nums[i] = Average;
48                }
49            }
50        }
51
52        return Math.Abs(nums.Max() - nums.Min());
53    }
54}