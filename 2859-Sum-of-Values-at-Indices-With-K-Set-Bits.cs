public class Solution 
{
    public int SumIndicesWithKSetBits(IList<int> nums, int k) 
    {
        int result = 0;

        for (int i = 0; i < nums.Count; i++)
        {
            int tempBinary = int.Parse(Convert.ToString(i,2));
            int TempCount = 0;
            while(tempBinary > 0)
            {
                if(tempBinary % 10 == 1)
                {
                    TempCount++;
                }
                tempBinary = tempBinary / 10;
            }
            if(TempCount == k)
            {
                result += nums[i];
            }
        }

        return result;
    }
}
