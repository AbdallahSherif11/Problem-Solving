public class Solution 
{
    public int SumOddLengthSubarrays(int[] arr) 
    {
        int Sum = 0;

        for (int i = 0; i < arr.Length; i++) // Decides the length
        {
            if ((i + 1) % 2 != 0)
            {
                for (int j = 0; j < (arr.Length - i); j++) // Decides the start index 
                {
                    for(int k = j; k < (i+1)+j ; k++)
                    {
                        Sum += arr[k];
                    }
                }
            }
        }

        return Sum;
    }
}
