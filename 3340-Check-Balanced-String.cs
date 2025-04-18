public class Solution 
{
    public bool IsBalanced(string num) 
    {
        int SumEven = 0;
        int SumOdd = 0;
        for (int i = 0; i < num.Length; i+=2)
        {
            SumEven += int.Parse(num[i].ToString());
        }
        for (int i = 1; i < num.Length; i += 2)
        {
            SumOdd += int.Parse(num[i].ToString());
        }
        if (SumEven == SumOdd)
        {
            return true;
        }
        return false;
    }
}
