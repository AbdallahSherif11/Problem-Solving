public class Solution 
{
    public int CountSymmetricIntegers(int low, int high) 
    {
        int SumA = 0;
        int SumB = 0;
        int Count = 0;
        for (int i = low; i <= high; i++)
        {
            SumA = 0;
            SumB = 0;
            if (i.ToString().Length % 2 == 0)
            {
                for(int j = 0; j < i.ToString().Length / 2; j++)
                {
                    SumA += i.ToString()[j];
                }
                for (int k = i.ToString().Length / 2; k < i.ToString().Length; k++)
                {
                    SumB += i.ToString()[k];
                }
                if (SumA == SumB) 
                {
                    Count++;
                }
            }
        }
        return Count;
    }
}
