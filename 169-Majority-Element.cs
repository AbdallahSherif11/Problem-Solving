1public class Solution 
2{
3    public int MajorityElement(int[] nums) 
4    {
5        int Result = 0;
6        int MajorityCount = nums.Length / 2;
7        List<int> numsList = nums.ToList();
8        List<int> Temp = new List<int>();
9        int Flag = 0;
10
11        for(int i  = 0; i < numsList.Count; i++)
12        {
13            Flag = numsList[i];
14            Temp = numsList.Where(X => X == Flag).ToList();
15            if(Temp.Count > MajorityCount)
16            {
17                Result = Flag;
18                break;
19            }
20            numsList.RemoveAll(X => X == Flag);
21        }
22
23        return Result;
24    }
25}
