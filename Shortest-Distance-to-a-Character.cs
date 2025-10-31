public class Solution 
{
    public int[] ShortestToChar(string s, char c) 
    {
        int[] Result = new int[s.Length];
        List<int> X = new List<int>();

        for(int i = 0; i < s.Length; i++)
        {
            if (s[i] == c)
            {
                Result[i] = 0;
                X.Add(i);
            }
        }
        for(int j = 0; j < s.Length; j++)
        {
            if (s[j] != c)
            {
                int Min = s.Length;
                foreach(int x in X)
                {
                    if (Math.Abs(x-j) < Min)
                    {
                        Min = Math.Abs(x - j);
                    }
                }
                Result[j] = Min;
            }
        }
        return Result;
    }
}