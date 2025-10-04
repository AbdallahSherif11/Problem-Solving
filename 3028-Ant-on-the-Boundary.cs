public class Solution 
{
    public int ReturnToBoundaryCount(int[] nums) 
    {
        int Edge = 0;
        int Result = 0;

        foreach (int num in nums)
        {
            Edge += num;
            
            if(Edge == 0)
            {
                Result++;
            }
        }

        return Result;
    }
}
