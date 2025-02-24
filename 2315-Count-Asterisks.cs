public class Solution 
{
    public int CountAsterisks(string s) 
    {
        int Count = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '|')
            {
                do
                {
                    i++;
                } while (s[i] != '|');
            }
            if (s[i] == '*')
            {
                Count++;
            }
        }

        return Count;
    }
}