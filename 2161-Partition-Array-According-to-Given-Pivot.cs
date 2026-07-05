public class Solution 
{
    public int[] PivotArray(int[] nums, int pivot) 
    {
        List<int> LessThan = new List<int>();
        List<int> GreaterThan = new List<int>();
        List<int> EqualPivot = new List<int>();

        for(int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < pivot) 
            {
                LessThan.Add(nums[i]);
            }
            else if(nums[i] > pivot)
            {
                GreaterThan.Add(nums[i]);
            }
            else
            {
                EqualPivot.Add(nums[i]);
            }
        }

        var Result = LessThan.Concat(EqualPivot).Concat(GreaterThan);

        return Result.ToArray();
    }
}