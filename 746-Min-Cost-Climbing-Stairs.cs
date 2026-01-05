1public class Solution 
2{
3    public int MinCostClimbingStairs(int[] cost) 
4    {
5        Dictionary<int,int> dp = new Dictionary<int,int>();
6        dp.Add(cost.Length,0);
7
8        int x = 0;
9        int y = 0;
10
11        for (int i = cost.Length - 1; i >= 0; i--)
12        {
13            x = (i + 2) < cost.Length ? dp[i + 2] : 0;
14            y = (i + 1) < cost.Length ? dp[i + 1] : 0;
15            dp.Add(i, cost[i] + Math.Min(x, y));
16        }
17
18        return Math.Min(dp[0], dp[1]);
19    }
20}
