public class Solution 
{
    public long GridGame(int[][] grid) 
    {
        int n = grid[0].Length;
        long[] prefixTop = new long[n + 1];
        long[] prefixBottom = new long[n + 1];

        for (int i = 0; i < n; i++) {
            prefixTop[i + 1] = prefixTop[i] + grid[0][i];
            prefixBottom[i + 1] = prefixBottom[i] + grid[1][i];
        }

        long result = long.MaxValue;

        for (int i = 0; i < n; i++) {
            long pointsTop = prefixTop[n] - prefixTop[i + 1];
            long pointsBottom = prefixBottom[i];

            long maxPointsBlue = Math.Max(pointsTop, pointsBottom);

            result = Math.Min(result, maxPointsBlue);
        }

        return result;
    }
}
