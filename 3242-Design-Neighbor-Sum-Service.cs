public class NeighborSum
{
    int[][] A;
    Dictionary<int, int[]> Pos = new Dictionary<int, int[]>();
    public NeighborSum(int[][] grid)
    {
        for (int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                Pos[grid[i][j]] = [i, j];
            }
        }
        A = grid;
    }

    public int AdjacentSum(int value)
    {
        int sum = 0;
        int[] Arr = Pos[value];
        if (Arr[1] + 1 < A.Length)
        {
            sum += A[Arr[0]][Arr[1] + 1]; 
        }
        if (Arr[1] - 1 >= 0)
        {
            sum += A[Arr[0]][Arr[1] - 1];
        }
        if (Arr[0] + 1 < A.Length)
        {
            sum += A[Arr[0] + 1][Arr[1]];
        }
        if (Arr[0] - 1 >= 0)
        {
            sum += A[Arr[0] - 1][Arr[1]];
        }
        return sum;
    }

    public int DiagonalSum(int value)
    {
        int sum = 0;
        int[] Arr = Pos[value];
        if (Arr[1] + 1 < A.Length && Arr[0] - 1 >= 0)
        {
            sum += A[Arr[0] - 1][Arr[1] + 1];
        }
        if (Arr[1] + 1 < A.Length && Arr[0] + 1 < A.Length)
        {
            sum += A[Arr[0] + 1][Arr[1] + 1];
        }
        if (Arr[1] - 1 >= 0 && Arr[0] - 1 >= 0)
        {
            sum += A[Arr[0] - 1][Arr[1] - 1];
        }
        if (Arr[1] - 1 >= 0 && Arr[0] + 1 < A.Length)
        {
            sum += A[Arr[0] + 1][Arr[1] - 1];
        }
        return sum;
    }
}

/**
 * Your NeighborSum object will be instantiated and called as such:
 * NeighborSum obj = new NeighborSum(grid);
 * int param_1 = obj.AdjacentSum(value);
 * int param_2 = obj.DiagonalSum(value);
 */