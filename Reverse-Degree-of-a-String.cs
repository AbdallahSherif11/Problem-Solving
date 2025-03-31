public class Solution 
{
    public int ReverseDegree(string s) 
    {
        int Sum = 0;
        Dictionary<char,int> D = new Dictionary<char,int>();
        int x = 26;

        for (char l = 'a'; l <= 'z'; l++)
        {
            D.Add(l, x);
            x--;
        }

        for(int i = 0; i < s.Length; i++)
        {
            Sum += D[s[i]] * (i+1);
        }

        return Sum;
    }
}