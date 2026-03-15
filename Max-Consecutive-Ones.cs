1public class Solution 
2{
3    public int FindMaxConsecutiveOnes(int[] nums) 
4    {
5        int Result = 0;
6        List<int> Nums = nums.ToList();
7        if(!nums.Contains(1))
8        {
9            return 0;
10        }
11        int FirstOne = Nums.IndexOf(1);
12        int SecondOne = Nums.IndexOf(1);
13        Result = 1;
14        for (int i = FirstOne; i < nums.Length - 1; i++)
15        {
16            FirstOne = Nums.IndexOf(1, i);
17            SecondOne = Nums.IndexOf(0, i+1) - 1;
18            if(FirstOne < 0)
19            {
20                break;
21            }
22            if(SecondOne < 0)
23            {
24                SecondOne = nums.Length - 1;
25                if (SecondOne - FirstOne + 1 > Result)
26                {
27                    Result = SecondOne - FirstOne + 1;
28                }
29                i = SecondOne - 1;
30                break;
31            }
32            if(SecondOne - FirstOne + 1 > Result)
33            {
34                Result = SecondOne - FirstOne + 1;
35                i = SecondOne;
36            }
37        }
38
39        return Result;
40    }
41}