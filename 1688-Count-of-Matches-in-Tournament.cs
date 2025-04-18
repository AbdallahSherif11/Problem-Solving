public class Solution 
{
    public int NumberOfMatches(int n) 
    {
        int CountMathces = 0;
        while (n > 1)
        {
            if (n % 2 == 0)
            {
                CountMathces += n / 2;
                n /= 2;
            }
            else
            {
                CountMathces += (n - 1) / 2;
                n = (n + 1) / 2;
            }
        }

        return CountMathces;
    }
}
