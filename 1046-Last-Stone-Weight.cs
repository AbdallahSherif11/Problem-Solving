1public class Solution 
2{
3    public int LastStoneWeight(int[] stones) 
4    {
5        List<int> StonesList = new List<int>();
6        StonesList = stones.ToList();
7
8        while( StonesList.Count > 1 )
9        {
10            StonesList.Sort();
11            StonesList.Reverse();
12            //StonesList.OrderByDescending(x => x).ToList();
13            if (StonesList[0] == StonesList[1])
14            {
15                StonesList.Remove(StonesList[0]);
16                StonesList.Remove(StonesList[0]);
17            }
18            else
19            {
20                StonesList[0] -= StonesList[1];
21                StonesList.Remove(StonesList[1]);
22            }
23        }
24        if( StonesList.Count > 0 )
25        {
26            return StonesList[0];
27        }
28
29        return 0;
30    }
31}
