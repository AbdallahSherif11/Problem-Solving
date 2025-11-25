public class Solution 
{
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d) 
    {
        int Count = 0;
        bool Temp = true;

        foreach (int X in arr1)
        {
            Temp = true;
            foreach (int Y in arr2)
            {
                if(Math.Abs(X - Y) <= d)
                {
                    Temp = false;
                    break;
                }
            }
            if (Temp)
            {
                Count++;
            }
        }

        return Count;
    }
}