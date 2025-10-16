public class Solution 
{
    public int[] AnswerQueries(int[] nums, int[] queries) 
    {
        int[] Result = new int[queries.Length];
        Array.Sort(nums);

        for(int i = 0; i < queries.Length;i++)
        {
            List<int> Temp = new List<int>();
            for(int j = 0; j < nums.Length; j++)
            {
                if(Temp.Sum() + nums[j] <= queries[i])
                {
                    Temp.Add(nums[j]);
                }
            }
            Result[i] = Temp.Count();
        }

        return Result;
    }
}
