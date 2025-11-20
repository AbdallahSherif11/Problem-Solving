public class Solution 
{
    public double LargestTriangleArea(int[][] points) 
    {
        double Result = 0;

        for(int i = 0; i < points.Length - 2; i++)
        {
            for(int j = i + 1; j < points.Length - 1; j++)
            {
                for (int k = j + 1; k < points.Length; k++)
                {
                    double Temp = 0.5 * Math.Abs((points[i][0] * (points[j][1] - points[k][1])) + (points[j][0] * (points[k][1] - points[i][1])) + (points[k][0] * (points[i][1] - points[j][1])));
                    if(Temp > Result)
                    {
                        Result = Temp;
                    }
                }
            }
        }

        return Result;
    }
}
