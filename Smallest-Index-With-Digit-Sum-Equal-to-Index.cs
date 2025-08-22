public class Solution 
{
    public int SmallestIndex(int[] nums) 
    {
        for (int i  = 0; i < nums.Length; i++)
        {
            int SumOfDigits = 0;
            int Temp = nums[i];
            while (Temp > 0)
            {
                SumOfDigits += Temp % 10;
                Temp /= 10;
            }
            if (SumOfDigits == i)
            {
                return i;
            }
        }
        return -1;
    }
}