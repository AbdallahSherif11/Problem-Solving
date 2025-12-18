1public class Solution 
2{
3    public int[][] ModifiedMatrix(int[][] matrix) 
4    {
5        int[] MaxEachColumn = new int[matrix[0].Length];
6        for(int i = 0; i < matrix.Length; i++)
7        {
8            for(int j = 0;  j < matrix[i].Length; j++)
9            {
10                if(matrix[i][j] > MaxEachColumn[j])
11                {
12                    MaxEachColumn[j] = matrix[i][j];
13                }
14            }
15        }
16        for (int i = 0; i < matrix.Length; i++)
17        {
18            for (int j = 0; j < matrix[i].Length; j++)
19            {
20                if (matrix[i][j] == -1)
21                {
22                    matrix[i][j] = MaxEachColumn[j];
23                }
24            }
25        }
26
27        return matrix;
28    }
29}
