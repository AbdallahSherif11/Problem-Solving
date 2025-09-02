public class Solution 
{
    public int FindLucky(int[] arr) 
    {
        int Result = 0;
        List<int> LuckyNumbers = new List<int>();
        Dictionary<int,int> Frequency = new Dictionary<int,int>();
        foreach (int i in arr)
        {
            if (!Frequency.ContainsKey(i))
            {
                Frequency.Add(i, 1);
            }
            else
            {
                Frequency[i]++;
            }
        }
        foreach (var X in Frequency)
        {
            if(X.Key == X.Value)
            {
                LuckyNumbers.Add(X.Key);
            }
        }
        Result = LuckyNumbers.Count == 0 ? -1 : LuckyNumbers.Max();

        return Result;
    }
}