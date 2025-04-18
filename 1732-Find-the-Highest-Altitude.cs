public class Solution 
{
    public int LargestAltitude(int[] gain) 
    {
        int Alt = 0;
        int MaxAlt = 0;
        for (int i = 0; i < gain.Length; i++)
        {
            Alt += gain[i];
            if (Alt > MaxAlt)
            {
                MaxAlt = Alt;
            }
        }
        return MaxAlt;
    }
}
