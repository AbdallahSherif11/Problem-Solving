public class Solution 
{
    public int[] ApplyOperations(int[] nums) 
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
            {
                nums[i] = nums[i] * 2;
                nums[i + 1] = 0;
            }
        }
        int[] Temp = nums.Where(X=> X != 0).ToArray();
        int[] Temp2 = nums.Where(X => X == 0).ToArray();
        List<int> Result = new List<int>();
        Result.AddRange(Temp);
        Result.AddRange(Temp2);

        return Result.ToArray();

    }
}
