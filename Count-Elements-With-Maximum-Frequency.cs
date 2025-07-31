public class Solution 
{
    public int MaxFrequencyElements(int[] nums)
    {
        int Result = 0;
        int MaxFrequency = 0;

        Dictionary<int, int> X = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!X.ContainsKey(nums[i]))
            {
                X.Add(nums[i], 1);
                if (MaxFrequency < 1)
                {
                    MaxFrequency = 1;
                }
            }
            else
            {
                X[nums[i]]++;
                if (X[nums[i]] > MaxFrequency)
                {
                    MaxFrequency = X[nums[i]];
                }
            }
        }
        Result = X.Count(pair => pair.Value == MaxFrequency) * MaxFrequency;

        return Result;
    }
}