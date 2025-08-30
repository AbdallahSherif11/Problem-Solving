public class Solution 
{
    public int[] NumberOfPairs(int[] nums) 
    {
        Dictionary<int,int> Frequency = new Dictionary<int,int>();
        int[] result = [0, 0];

        foreach (int i in nums)
        {
            if (!Frequency.ContainsKey(i))
            {
                Frequency.Add(i, 1);
            }
            else
            {
                Frequency[i]++;
            }
        }
        foreach(var X in Frequency)
        {
            if ( X.Value % 2 == 0)
            {
                result[0] += X.Value / 2;
            }
            else if (X.Value % 2 == 1 && X.Value > 2)
            {
                result[0] += X.Value / 2;
                result[1]++;
            }
            else
            {
                result[1]++;
            }
        }

        return result;
    }
}
