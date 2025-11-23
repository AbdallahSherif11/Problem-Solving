public class Solution 
{
    public double TrimMean(int[] arr) 
    {
        Array.Sort(arr);
        List<int> X = new List<int>();
        X = arr.ToList();
        int removeCount = arr.Length * 5 / 100;
        X.RemoveRange(0, removeCount);
        X.Reverse();
        X.RemoveRange(0, removeCount);

        return (double)X.Sum() / (double)X.Count();
    }
}
