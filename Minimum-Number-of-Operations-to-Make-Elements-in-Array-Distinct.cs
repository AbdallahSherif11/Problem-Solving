public class Solution 
{
    public int MinimumOperations(int[] nums) 
    {
        int Result = 0;
        List<int> L = new List<int>();
        L = nums.ToList();

        while(L.Distinct().Count() != L.Count())
        {
            if(L.Count() > 3)
            {
                L.RemoveRange(0, 3);
            }
            else
            {
                L.RemoveRange(0, L.Count());
            }
            Result++;
        }

        return Result;
    }
}