public class Solution 
{
    public int CountCompleteDayPairs(int[] hours)
    {
        int Result = 0;
        for(int i = 0; i < hours.Length - 1; i++)
        {
            for(int j = i + 1; j < hours.Length; j++)
            {
                if ((hours[i] + hours[j]) % 24 == 0)
                {
                    Result++;
                }
            }
        }
        return Result;
    }
}