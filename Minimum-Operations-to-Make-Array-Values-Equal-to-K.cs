public class Solution 
{
    public int MinOperations(int[] nums, int k) 
    {
        if(nums.Length == 1 && k > nums[0])
        {
            return -1;
        }
        int h = 0;
        int Result = 0;
        Array.Sort(nums);
        while (nums.Min()!= k || nums.Max() != k)
        {
            int[] Temp = nums.Where(X => X != nums.Max()).ToArray();
            if(Temp.Length > 0)
            {
                h = Temp.Last();
            }
            else
            {
                h = k;
            }
            if (h < k)
            {
                return -1;
            }
            for(int  i = 0; i < nums.Length; i++)
            {
                if (nums[i] > h)
                {
                    nums[i] = h;
                }
            }

            Result++;
        }
        return Result;
    }
}