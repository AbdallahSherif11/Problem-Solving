public class Solution 
{
    public int DifferenceOfSum(int[] nums) 
    {
        int NormalSum = 0;
        int DigitSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            NormalSum += nums[i];
        }
        for (int i = 0;i < nums.Length; i++)
        {
            int Temp = nums[i];
            while (Temp > 0)
            {
                int Digit = Temp % 10;
                DigitSum += Digit;
                Temp /= 10;
            }
        }
        return Math.Abs(NormalSum - DigitSum);
    }
}