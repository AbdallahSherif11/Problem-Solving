public class Solution 
{
    public int MaxProduct(int[] nums) 
    {
        int MaxP = 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i+1; j < nums.Length; j++)
            {
                int Temp = (nums[i] - 1) * (nums[j] - 1);
                if(Temp > MaxP) 
                {
                    MaxP = Temp;
                }
            }
        }

        return MaxP;
    }
}