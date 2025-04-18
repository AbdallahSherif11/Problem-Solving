public class Solution 
{
    public int SubtractProductAndSum(int n) 
    {
        int Product = 1;
        int Sum = 0;

        while (n > 0)
        {
            Product *= (n % 10);
            Sum += (n % 10);
            n = n / 10;
        }

        return Product - Sum;
    }
}
