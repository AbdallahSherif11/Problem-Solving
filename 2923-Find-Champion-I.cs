public class Solution 
{
    public int FindChampion(int[][] grid) 
    {
        int Result = 0;
        int Max = 0;

        for(int i = 0; i < grid.Length; i++)
        {
            int Count = grid[i].Count(X => X == 1);
            if (Count > Max)
            {
                Result = i;
                Max = Count;
            }
        }

        return Result;
    }
}
