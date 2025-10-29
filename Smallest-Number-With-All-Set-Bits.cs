public class Solution 
{
    public int SmallestNumber(int n) 
    {
        string binary = Convert.ToString(n, 2);
        if (!binary.Contains('0'))
        {
            return n;
        }
        string Temp = "";
        for(int i = 0; i < binary.Length; i++)
        {
            Temp += '1';
        }
        int number = Convert.ToInt32(Temp, 2);
        return number;
    }
}