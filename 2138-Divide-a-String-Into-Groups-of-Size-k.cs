public class Solution 
{
    public string[] DivideString(string s, int k, char fill) 
    {
        int All = s.Length / k;
        if (s.Length % k != 0)
        {
            All++;
        }
        string[] Result = new string[All];
        for (int i = 0; i < All; i++)
        {
            int Y = i * k + k;
            for (int x = i * k; x < Y; x++)
            {
                if (x < s.Length)
                {
                    Result[i] += s[x];
                }
                else
                {
                    Result[i] += fill;
                }
            }
        }

        return Result;
    }
}
