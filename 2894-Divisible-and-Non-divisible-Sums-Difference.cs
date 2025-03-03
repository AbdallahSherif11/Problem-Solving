public class Solution 
{
    public int DifferenceOfSums(int n, int m) 
    {
        int Difference = 0;
        int SumDivisible = 0;
        int SumNonDivisible = 0;

        for (int i = 0; i <= n ; i++)
        {
            if (i % m == 0)
            {
                SumNonDivisible += i;
            }
            else
            {
                SumDivisible += i;
            }
        }
        Difference = SumDivisible - SumNonDivisible;

        return Difference;
    }   
}
