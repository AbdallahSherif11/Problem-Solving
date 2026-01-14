1public class Solution 
2{
3    public int EarliestTime(int[][] tasks) 
4    {
5        List<int> Temp = new List<int>();
6        for (int i = 0; i < tasks.Length; i++)
7        {
8            Temp.Add(tasks[i][0] + tasks[i][1]);
9        }
10
11        return Temp.Min();
12    }
13}
