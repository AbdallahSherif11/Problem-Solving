public class Solution 
{
    public int[] Decode(int[] encoded, int first) 
    {
        int[] Result = new int[encoded.Length + 1];
        Result[0] = first;

        for (int i = 0; i < Result.Length - 1; i++)
        {
            Result[i + 1] = encoded[i] ^ Result[i];
        }

        return Result;
    }
}