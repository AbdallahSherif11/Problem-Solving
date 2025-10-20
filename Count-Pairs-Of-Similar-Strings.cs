public class Solution 
{
    public int SimilarPairs(string[] words) 
    {
        int Result = 0;
        string[] Temp = new string[words.Length];
        int i = 0;
        foreach(string word in words)
        {
            char[] X = word.ToCharArray();
            X = X.Distinct().ToArray();
            Array.Sort(X);
            Temp[i] = string.Concat(X);
            i++;
        }

        for(int j = 0; j < Temp.Length - 1; j++)
        {
            for(int k = j + 1; k < Temp.Length; k++)
            {
                if (Temp[j] == Temp[k])
                {
                    Result++;
                }
            }
        }

        return Result;
    }
}