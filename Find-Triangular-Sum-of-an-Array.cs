public class Solution 
{
    public int TriangularSum(int[] nums) 
    {
        List<int> Temp = nums.ToList();

        for (int i = 0; i < nums.Length - 1; i++)
        {
            for(int j = 0; j < Temp.Count - 1; j++)
            {
                Temp[j] = (Temp[j] + Temp[j + 1]) % 10;
            }


            Temp.RemoveAt(Temp.Count - 1);
        }

        return Temp[0];
    }
}