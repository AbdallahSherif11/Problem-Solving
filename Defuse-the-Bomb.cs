public class Solution 
{
    public int[] Decrypt(int[] code, int k) 
    {
        int[] Result = new int[code.Length];
        for (int i = 0; i < code.Length; i++)
        {
            if (k > 0)
            {
                for (int j = 1; j <= k; j++)
                {
                    int Temp = i + j;
                    if ((i + j) >= code.Length)
                    {
                        Temp = Temp - code.Length;
                    }
                    Result[i] += code[Temp];
                }
            }
            else if(k < 0)
            {
                for (int j = 1; j <= -k; j++)
                {
                    int Temp = i - j;
                    if ((i - j) < 0)
                    {
                        Temp = Temp + code.Length;
                    }
                    Result[i] += code[Temp];
                }
            }
            else
            {
                for(int j = 0; j < code.Length; j++)
                {
                    Result[i] = 0;
                }
            }
        }

        return Result;
    }
}