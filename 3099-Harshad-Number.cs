public class Solution 
{
    public int SumOfTheDigitsOfHarshadNumber(int x) 
    {
        int SumDigit = 0;
        int Temp = x;
        while (Temp > 0)
        {
            SumDigit += Temp % 10;
            Temp /= 10;
        }
        if(x % SumDigit == 0)
        {
            return SumDigit;
        }
        return -1;
    }
}