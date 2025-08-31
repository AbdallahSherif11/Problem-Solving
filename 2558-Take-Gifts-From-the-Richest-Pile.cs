public class Solution 
{
    public long PickGifts(int[] gifts, int k) 
    {
        long Result = 0;
        for(int i = 0; i < k; i++)
        {
            var Temp = gifts.Max();
            var X = Array.IndexOf(gifts, Temp);
            gifts[X] = (int)Math.Sqrt(Temp);
        }
        foreach(var Y in gifts)
        {
            Result += Y;
        }

        return Result;
    }
}
