public class Solution 
{
    public int[] ReplaceElements(int[] arr) 
    {
        int[] Result = new int[arr.Length];
        Result[arr.Length - 1] = -1;
        int Max = arr[arr.Length - 1];

        for(int i = arr.Length - 2; i >= 0; i--)
        {
            Result[i] = Max;
            if(arr[i] > Max)
            {
                Max = arr[i];
            }
        }

        return Result;
    }
}
