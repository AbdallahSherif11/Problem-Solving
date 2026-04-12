1public class Solution 
2{
3    public int[] FindDegrees(int[][] matrix) 
4    {
5        List<int> Result = new List<int>();
6
7        for(int i = 0; i< matrix.Length; i++)
8        {
9            Result.Add(0);
10            for(int j = 0; j < matrix[i].Length; j++)
11            {
12                Result[i] += matrix[i][j];
13            }
14        }
15
16        return Result.ToArray();
17    }
18}