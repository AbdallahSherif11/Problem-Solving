public class Solution 
{
    public int[] FindXSum(int[] nums, int k, int x) 
    {
        List<int> Result = new List<int>();
        //int Min = nums.Distinct().Count();

        for (int i = 0; i <= nums.Length - k; i++)
        {
            Dictionary<int,int> Freq = new Dictionary<int,int>();
            int Test = 0;
            for(int j = i; j < k+i; j++)
            {
                if (!Freq.ContainsKey(nums[j]))
                {
                    Freq.Add(nums[j], 1);
                }
                else
                {
                    Freq[nums[j]]++;
                }
                Test += nums[j];
            }
            var Y = Freq.OrderByDescending(x => x.Key).ToList();
            var X = Y.OrderByDescending(x => x.Value).ToList();
            int Min = X.Distinct().Count();

            int Temp = 0;
            if(Min < x )
            {
                Temp = Test;
            }
            else
            {
                for (int l = 0;l < x && l < Min; l++)
                {
                    Temp += X[l].Value * X[l].Key;
                }
            }
            Result.Add(Temp);
        }

        return Result.ToArray();
    }
}
