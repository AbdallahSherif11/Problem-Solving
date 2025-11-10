public class Solution 
{
    public int[] MaxKDistinct(int[] nums, int k) 
    {
        List<int> X = new List<int>();
        X = nums.Distinct().ToList();
        X = X.OrderByDescending(x=> x).ToList();
        int[] Result = new int[k];
        Result = X.Take(k).ToArray();

        return Result;
    }
}