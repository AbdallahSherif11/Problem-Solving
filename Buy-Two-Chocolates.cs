1public class Solution 
2{
3    public int BuyChoco(int[] prices, int money) 
4    {
5        int Temp = money;
6
7        Array.Sort(prices);
8        Temp = money - prices[0] - prices[1];
9        if(Temp < 0)
10        {
11            return money;
12        }
13
14        return Temp;
15    }
16}