public class Solution 
{
    public bool CanAliceWin(int[] nums) 
    {
        int SumAlice = 0;
        int SumBob = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 9)
            {
                SumAlice += nums[i];
            }
            else
            {
                SumBob += nums[i];
            }
        }
        if(SumAlice != SumBob)
        {
            return true;
        }
        return false;
    }
}