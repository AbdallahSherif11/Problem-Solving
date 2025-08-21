public class Solution 
{
    public int FindDelayedArrivalTime(int arrivalTime, int delayedTime)
    {
        int Result = arrivalTime + delayedTime;
        if (Result >= 24)
        {
            return Result - 24;
        }
        return Result;
    }
}