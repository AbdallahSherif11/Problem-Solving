public class Solution 
{
    public int MaxFrequencyElements(int[] nums)
    {
        int Result = 0;
        int MaxFrequency = 1;

        Dictionary<int, int> X = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if (!X.ContainsKey(nums[i]))
            {
                X.Add(nums[i], 1);
            }
            else
            {
                X[nums[i]]++;
                if(X[nums[i]] > MaxFrequency)
                {
                    MaxFrequency = X[nums[i]];
                }
            }
        }
        foreach (var k in X)
        {
            if (k.Value == MaxFrequency)
            {
                Result += MaxFrequency;
            }
        }

        return Result;
    }
}
