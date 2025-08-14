public class Solution 
{
    public IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2) 
    {
        Dictionary<int,int> Totals = new Dictionary<int,int>();
        for(int i = 0; i < items1.Length; i++)
        {
            if (!Totals.ContainsKey(items1[i][0]))
            {
                Totals.Add(items1[i][0], items1[i][1]);
            }
            else
            {
                Totals[items1[i][0]] += items1[i][1];
            }
        }
        for (int i = 0; i < items2.Length; i++)
        {
            if (!Totals.ContainsKey(items2[i][0]))
            {
                Totals.Add(items2[i][0], items2[i][1]);
            }
            else
            {
                Totals[items2[i][0]] += items2[i][1];
            }
        }
        var Result = Totals.OrderBy(X => X.Key).ToList();
        IList<IList<int>> ints = new List<IList<int>>();
        foreach(var x in Result)
        {
            ints.Add([x.Key, x.Value]);
        }
        return ints;
    }
}
