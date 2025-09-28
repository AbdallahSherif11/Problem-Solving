public class Solution 
{
    public int[] KWeakestRows(int[][] mat, int k) 
    {
        Dictionary<int,int> People = new Dictionary<int,int>();

        for(int i = 0; i < mat.Length; i++)
        {
            int Ones = 0;
            for(int j = 0; j < mat[i].Length; j++)
            {
                if(mat[i][j] == 1) 
                {
                    Ones++; 
                }
            }
            People.Add(i, Ones);
        }
        var X = People.OrderBy(X => X.Value);
        int[] Temp = new int[mat.Length];
        int z = 0;
        foreach (var x in X)
        {
            Temp[z] = x.Key;
            z++;
        }
        return Temp.Take(k).ToArray();
    }
}
