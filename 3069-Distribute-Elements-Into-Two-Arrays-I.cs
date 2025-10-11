public class Solution 
{
    public int[] ResultArray(int[] nums) 
    {
        List<int> X = new List<int>();
        List<int> Y = new List<int>();
        X.Add(nums[0]);
        Y.Add(nums[1]);
        for (int i = 2; i < nums.Length; i++)
        {
            if(X.Last() > Y.Last())
            {
                X.Add(nums[i]);
            }
            else
            {
                Y.Add(nums[i]);
            }
        }

        return X.Concat(Y).ToArray();
    }
}
