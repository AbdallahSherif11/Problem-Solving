1public class Solution 
2{
3    public int[] MinBitwiseArray(IList<int> nums) 
4    {
5        int[] Result = new int[nums.Count];
6
7        List<int> Temp = new List<int>(Enumerable.Range(1, 1000));
8
9        for (int i = 0; i < nums.Count; i++)
10        {
11            for(int j = 0; j < Temp.Count; j++)
12            {
13                if ((Temp[j] | (Temp[j] + 1)) == nums[i])
14                {
15                    Result[i] = Temp[j];
16                    break;
17                }
18            }
19            if (Result[i] == 0)
20            {
21                Result[i] = -1;
22            }
23        }
24
25        return Result;
26    }
27}
