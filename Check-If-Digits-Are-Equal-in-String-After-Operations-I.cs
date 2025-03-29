public class Solution 
{
    public bool HasSameDigits(string s) 
    {
        List<char> R1 = new List<char>();
        R1 = s.ToList();

        List<char> RTemp = new List<char>();

        for (int i = 0; i < s.Length - 2; i++)
        {
            for (int j = 0; j < R1.Count - 1; j++)
            {
                double x = (char.GetNumericValue(R1[j]) + char.GetNumericValue(R1[j + 1])) % 10;
                RTemp.Add(char.Parse( x.ToString() ));
            }
            R1 = RTemp;
            RTemp = new List<char>();
        }
        return (R1[0] == R1[1]);
    }
}