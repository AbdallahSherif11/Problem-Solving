public class Solution 
{
    public int MaxWidthOfVerticalArea(int[][] points) 
    {
        int MaxWidth = 0;

        Array.Sort(points, (x, y) => x[0].CompareTo(y[0]));
        
        for (int i = 0; i < points.Length - 1; i++)
        {
            if (points[i+1][0] -  points[i][0] > MaxWidth)
            {
                MaxWidth = points[i + 1][0] - points[i][0];
            }
        }

        return MaxWidth;
    }
}