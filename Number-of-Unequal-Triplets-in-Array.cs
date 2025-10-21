public class Solution 
{
    public int UnequalTriplets(int[] nums) 
    {
        int Result = 0;
        List<List<int>> X = new List<List<int>>();

        for(int i = 0; i < nums.Length - 2; i++)
        {
            for(int j = i+1; j < nums.Length - 1; j++)
            {
                for(int k = j+1; k < nums.Length; k++)
                {
                    X.Add([nums[i], nums[j], nums[k]]);
                }
            }
        }
        Result = X.Where(x => x[0] != x[1] && x[0] != x[2] && x[1] != x[2]).Count();
        //return X.Where(x=> x[0] != x[1] && x[0] != x[2] && x[1] != x[2]).Count();
        return Result;
    }
}