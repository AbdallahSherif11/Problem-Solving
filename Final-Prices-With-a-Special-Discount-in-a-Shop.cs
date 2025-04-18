public class Solution 
{
    public int[] FinalPrices(int[] prices) 
    {
        int[] Discounted = new int[prices.Length];
        Array.Copy(prices, Discounted, prices.Length);

        for (int i = 0; i < prices.Length - 1; i++)
        {
            for (int j = i+1; j < prices.Length; j++)
            {
                if (prices[j] <= prices[i])
                {
                    Discounted[i] = prices[i] - prices[j];
                    break;
                }
            }
        }

        return Discounted;
    }
}