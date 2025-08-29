public class Solution 
{
    public int BusyStudent(int[] startTime, int[] endTime, int queryTime) 
    {
        int Result = 0;
        for(int i = 0; i < startTime.Length; i++)
        {
            if(queryTime >= startTime[i] && queryTime <= endTime[i])
            {
                Result++;
            }
        }

        return Result;
    }
}