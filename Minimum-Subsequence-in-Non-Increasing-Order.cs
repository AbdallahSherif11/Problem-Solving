public class Solution 
{
    public IList<int> MinSubsequence(int[] nums) 
    {
        List<int> result = new List<int>();
        List<int> Lnums = new List<int>();
        Array.Sort(nums);
        Lnums = nums.ToList();
        result.Add(Lnums.Last());
        Lnums.RemoveAt(Lnums.Count - 1);
        while (Lnums.Count > 0)
        {
            if(result.Sum() > Lnums.Sum())
            {
                break;
            }
            result.Add(Lnums.Last());
            Lnums.RemoveAt(Lnums.Count - 1);
            if(result.Sum() > Lnums.Sum())
            {
                break;
            }
        }

        return result;
    }
}