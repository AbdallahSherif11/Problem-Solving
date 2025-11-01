public class Solution 
{
    public bool AreNumbersAscending(string s) 
    {
        string[] X = s.Split(' ');
        List<int> Y = new List<int>();
        foreach(string x in X)
        {
            if (int.TryParse(x, out int v))
            {
                Y.Add(v);
            }
        }

        for(int i = 0; i < Y.Count - 1; i++)
        {
            if(Y[i+1] <= Y[i])
            {
                return false;
            }
        }

        return true;
    }
}
