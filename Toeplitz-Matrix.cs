1public class Solution 
2{
3    public bool IsToeplitzMatrix(int[][] matrix) 
4    {
5        if(matrix.Length == 1 || matrix[0].Length == 1) return true;
6        bool Result = true;
7
8        for(int i = 1; i < matrix.Length;i++)
9        {
10            for(int j = 1; j < matrix[i].Length; j++)
11            {
12                if (matrix[i][j] != matrix[i - 1][j - 1])
13                {
14                    Result = false;
15                    break;
16                }
17            }
18        }
19
20        return Result;
21    }
22}