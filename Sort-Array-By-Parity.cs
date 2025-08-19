public class Solution 
{
    public int[] SortArrayByParity(int[] nums) 
    {
        int[] Even = nums.Where(X=> X % 2 == 0).ToArray();
        int[] Odd = nums.Where(X=> X % 2 == 1).ToArray();
        int[] Result = Even.Concat(Odd).ToArray();

        return Result;
    }
}