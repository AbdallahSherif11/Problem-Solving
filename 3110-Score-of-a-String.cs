public class Solution 
{
    public int ScoreOfString(string s)
    {
        int Score = 0;
        int[] Arr = new int[s.Length];
        for (int i = 0; (i < (s.Length - 1)); i++)
        {
            Arr[i] = Math.Abs(s[i] - s[i + 1]);
        }
        foreach (var i in Arr)
        {
            Score += i;
        }
        return Score;
    }
}