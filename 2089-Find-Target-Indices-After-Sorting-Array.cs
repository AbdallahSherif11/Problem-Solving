public class Solution 
{
    public IList<int> TargetIndices(int[] nums, int target) 
    {
        List<int> Result = new List<int>();
        Array.Sort(nums);
        for(int i  = 0; i < nums.Length; i++)
        {
            if(nums[i] == target)
            {
                Result.Add(i);
            }
        }
        int[] Result2 = Result.ToArray();
        Array.Sort(Result2);
        List<int> Result3 = Result2.ToList();
        return Result3;
    }
}
