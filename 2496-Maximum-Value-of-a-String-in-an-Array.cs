public class Solution 
{
    public int MaximumValue(string[] strs) 
    {
        int[] Temp = new int[strs.Length];
        for(int i = 0; i < strs.Length; i++)
        {
            if (!int.TryParse(strs[i], out Temp[i]))
            {
                Temp[i] = strs[i].Length;
            }
        }

        return Temp.Max();
    }
}
