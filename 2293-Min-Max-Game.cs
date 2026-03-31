1public class Solution 
2{
3    public int MinMaxGame(int[] nums) 
4    {
5        int Result = 0;
6
7        List<int> Nums = nums.ToList();
8        List<int> Temp = new List<int>();
9        bool Flag = true;
10
11        while (Nums.Count != 1)
12        {
13            for(int i = 0; i < Nums.Count; i+=2)
14            {
15                if(Flag)
16                {
17                    Temp.Add(Math.Min(Nums[i], Nums[i+1]));
18                    Flag = false;
19                }
20                else
21                {
22                    Temp.Add(Math.Max(Nums[i], Nums[i + 1]));
23                    Flag = true;
24                }
25            }
26            Nums = new List<int>(Temp);
27            Temp = new List<int>();
28        }
29
30        return Nums[0];
31    }
32}
