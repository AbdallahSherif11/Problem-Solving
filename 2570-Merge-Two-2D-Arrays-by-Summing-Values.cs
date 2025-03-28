public class Solution 
{
    public int[][] MergeArrays(int[][] nums1, int[][] nums2) 
    {
        Dictionary<int,int> x = new Dictionary<int,int>();
        for (int i = 0; i < nums1.Length; i++)
        {
            if (!x.ContainsKey(nums1[i][0]))
            {
                x.Add(nums1[i][0],nums1[i][1]);
            }
        }

        for (int i = 0; i < nums2.Length; i++)
        {
            if (!x.ContainsKey(nums2[i][0]))
            {
                x.Add(nums2[i][0], nums2[i][1]);
            }
            else
            {
                x[nums2[i][0]] += nums2[i][1];
            }
        }

        var y = x.OrderBy(s=> s.Key).ToList();

        int[][] Result = new int[y.Count][];

        int Counter = 0;
        foreach(var temp in y)
        {
            Result[Counter] = [temp.Key,temp.Value];
            Counter++;
        }

        return Result;
    }
}
