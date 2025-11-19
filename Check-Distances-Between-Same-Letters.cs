public class Solution 
{
    public bool CheckDistances(string s, int[] distance) 
    {
        bool Result = true;
        Dictionary<char,int> distances = new Dictionary<char,int>();
        char c = 'a';
        for(int i = 0; i < distance.Length; i++)
        {
            distances.Add(c, i);
            c++;
        }
        foreach(char X in s)
        {
            if(s.LastIndexOf(X) - s.IndexOf(X) - 1 != distance[distances[X]])
            {
                return false;
            }
        }
        return Result;
    }
}