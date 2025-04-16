public class Solution 
{
    public int CountTestedDevices(int[] batteryPercentages) 
    {
        int Count = 0;

        for (int i = 0; i < batteryPercentages.Length; i++)
        {
            if(batteryPercentages[i] - Count > 0)
            {
                Count++;
            }
        }

        return Count;
    }
}