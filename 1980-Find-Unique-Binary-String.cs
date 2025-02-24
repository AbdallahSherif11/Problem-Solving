public class Solution 
{
    public string FindDifferentBinaryString(string[] nums) 
    {
        int x = nums.Length;
        int y = (int)Math.Pow(2,x);
        List<string> AllNums = new List<string>();
        List<string> Input = nums.ToList();
        for (int i = 0; i < y; i++)
        {
            AllNums.Add(Convert.ToString(i, 2).PadLeft(x, '0'));
        }

        List<string> Output = new List<string>();
        Output = AllNums.Except(Input).ToList();

        return Output[0];
    }
}