public class Solution 
{
    public int SmallestEvenMultiple(int n) 
    {
        if (n % 2  == 0)
        {
            return n;
        }
        return 2 * n;
    }
}
