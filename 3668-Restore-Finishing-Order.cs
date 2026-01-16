1public class Solution 
2{
3    public int[] RecoverOrder(int[] order, int[] friends) 
4    {
5        int[] Result = new int[friends.Length];
6        int j = 0;
7
8        for (int i = 0; i < order.Length;i++)
9        {
10            if (friends.Contains(order[i]))
11            {
12                Result[j] = order[i];
13                j++;
14            }
15        }
16
17        return Result;
18    }
19}
