public class Solution 
{
    public int[] FindThePrefixCommonArray(int[] A, int[] B) 
    {
        int n = A.Length;
        int[] result = new int[n];
        List<int> TempArr = new List<int>();
        int Count = 0;

        for(int i = 0; i < n; i++)
        {
            Count = 0;
            for(int j = 0; j <= i; j++)
            {
                TempArr.Add(A[j]);
            }
            for(int k = 0;k <= i; k++)
            {
                if (TempArr.Contains(B[k]))
                {
                    Count++;
                }
            }
            result[i] = Count;

            TempArr.Clear();
        }

        return result;
    }
}