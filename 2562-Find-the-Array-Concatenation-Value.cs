public class Solution 
{
    public long FindTheArrayConcVal(int[] nums) 
    {
        long Result = 0;
        if(nums.Length == 1)
        {
            return nums[0];
        }
        else
        {
            if(nums.Length % 2 == 0)
            {
                int i = 0;
                int j = nums.Length - 1;
                int HalfForward = nums.Length / 2;
                for(i = 0; i < HalfForward; i++)
                {
                    string Temp = $"{nums[i]}" + $"{nums[j]}";
                    Result += int.Parse(Temp);
                    j--;
                }
            }
            else
            {
                int i = 0;
                int j = nums.Length - 1;
                int HalfForward = nums.Length / 2;
                for (i = 0; i < HalfForward; i++)
                {
                    string Temp = $"{nums[i]}" + $"{nums[j]}";
                    Result += int.Parse(Temp);
                    j--;
                }
                Result += nums[i];
            }
        }
        return Result;
    }
}
