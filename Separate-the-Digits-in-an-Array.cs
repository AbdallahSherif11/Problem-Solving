public class Solution 
{
    public int[] SeparateDigits(int[] nums) 
    {
        List<int> Result = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            string Temp = nums[i].ToString();
            for (int j = 0; j < Temp.Length; j++)
            {
                Result.Add((int)char.GetNumericValue(Temp[j]));
            }
        }
        return Result.ToArray();
    }
}