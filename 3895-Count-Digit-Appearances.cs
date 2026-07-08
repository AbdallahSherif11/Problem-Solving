public class Solution 
{
    public int CountDigitOccurrences(int[] nums, int digit) 
    {
        int Result = 0;
        char C = (char)(digit + '0');
        int Temp = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            Temp = nums[i].ToString().Count(X => X == C);
            Result += Temp;
        }

        return Result;
    }
}