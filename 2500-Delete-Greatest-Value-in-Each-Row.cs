public class Solution 
{
    public int DeleteGreatestValue(int[][] grid) 
    {
        int Sum = 0;
        List<List<int>> myList = new List<List<int>>();

        for (int i = 0; i < grid.Length; i++)
        {
            myList.Add(new List<int>());
            for (int j = 0; j < grid[i].Length; j++)
            {
                myList[i].Add(grid[i][j]);
            }
        }

        for (int i = 0; i < grid[0].Length; i++)
        {
            int x = int.MinValue;

            for(int j = 0; j < myList.Count; j++)
            {
                if (myList[j].Count == 0)
                {
                    x = 0;
                    break;
                }
                x = Math.Max(x, myList[j].Max());
                myList[j].Remove(myList[j].Max());
            }
            Sum += x;

        }

        return Sum;
    }
}
