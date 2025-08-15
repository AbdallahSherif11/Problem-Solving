public class Solution 
{
    public IList<int> FindKDistantIndices(int[] nums, int key, int k)
    {
        List<int> distantIndecies = new List<int>();
        List<int> Result = new List<int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == key)
            {
                distantIndecies.Add(i);
            }
        }
        for(int i = 0; i < nums.Length; i ++)
        {
            foreach(int j in distantIndecies)
            {
                if (Math.Abs(i-j) <= k)
                {
                    Result.Add(i);
                }
            }
        }
        Result.Sort();
        var x = Result.Distinct().ToList();
        return x;

    }
}