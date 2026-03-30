1public class Solution 
2{
3    public bool KLengthApart(int[] nums, int k) 
4    {
5        int CurrentOne = Array.IndexOf(nums, 1);
6        int Temp = Array.IndexOf(nums, 1, CurrentOne + 1);
7        if(CurrentOne == -1 || Temp == -1)
8        {
9            return true;
10        }
11
12        for (int i = CurrentOne + 1; i < nums.Length - 1; i++)
13        {
14            Temp = Array.IndexOf(nums, 1, i + 1);
15            if (Temp == -1)
16            {
17                break;
18            }
19            if (Temp - CurrentOne - 1 < k)
20            {
21                return false;
22            }
23            else
24            {
25                CurrentOne = Temp;
26                i = Temp - 1;
27            }
28        }
29
30        return true;
31    }
32}