public class Solution 
{
    public int[] FrequencySort(int[] nums) 
    {
        Dictionary<int,int> Freq = new Dictionary<int,int>();
        for (int i = 0;i < nums.Length;i++)
        {
            if (!Freq.ContainsKey(nums[i]))
            {
                Freq[nums[i]] = 1;
            }
            else
            {
                Freq[nums[i]]++;
            }
        }
        var x = Freq.OrderBy(x => x.Value).ThenByDescending(x=> x.Key).ToList();
        List<int> y = new List<int>();
        for(int j = 0; j < x.Count; j++)
        {
            for(int k = 0; k < x[j].Value; k++)
            {
                y.Add(x[j].Key);
            }
        }            

        return y.ToArray();
    }
}