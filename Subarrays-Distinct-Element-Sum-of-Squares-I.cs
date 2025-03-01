public class Solution 
{
    public int SumCounts(IList<int> nums) 
    {
        int SumCount = 0;
        List<List<int>> BigArr = new List<List<int>>();

        for (int x = 0; x < nums.Count; x++)
        {
            for (int y = nums.Count - x; y > 0; y--)
            {
                int j = nums.Count - x - y;

                List<int> SmallArr = new List<int>();
                for (int i = j; i <= (x + j); i++)
                {
                    SmallArr.Add(nums[i]);
                }
                BigArr.Add(SmallArr);
            }
        }

        foreach ( var z in BigArr )
        {
            int temp = z.Distinct().Count();
            SumCount += (int)Math.Pow(temp,2);
        }

        return SumCount;
    }
}