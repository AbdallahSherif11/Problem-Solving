public class Solution 
{
    public int MinDeletion(string s, int k) 
    {
        Dictionary<char, int> Counts = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (Counts.ContainsKey(c))
            {
                Counts[c]++;
            }
            else
            {
                Counts.Add(c, 1);
            }
        }

        var Y = Counts.OrderBy(C => C.Value);
        int d = Y.Count() - k;
        int Result = 0;
        if (d <= 0) return 0;

        int i = 0;
        foreach (var X in Y)
        {
            Result += X.Value;
            i++;
            if (i == d) break;
        }
        return Result;
    }
}