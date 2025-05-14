public class Solution {
    public int Search(int[] nums, int target) 
    {
        int L = 0;
        int R = nums.Length-1;
        int M = (R + L) / 2;
        while (R >= L)
        {
            if (nums[M] == target)
            {
                return M;
            }
            else if (nums[M] > target)
            {
                R = M - 1;
            }
            else
            {
                L = M + 1;
            }
            M = (R + L) / 2;
        }
        return -1;
    }
}