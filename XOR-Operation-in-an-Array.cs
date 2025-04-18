public class Solution 
{
    public int XorOperation(int n, int start) 
    {
        int BitwiseXORall = 0;
        int[] Arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Arr[i] = start + 2 * i;
        }

        for (int i = 0; i < n; i++)
        {
            BitwiseXORall ^= Arr[i];
        }

        return BitwiseXORall;
    }
}