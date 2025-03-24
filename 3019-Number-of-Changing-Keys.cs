public class Solution 
{
    public int CountKeyChanges(string s) 
    {
        int Count = 0;

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (char.ToLower(s[i]) != char.ToLower(s[i + 1]))
            {
                Count++;
            }
        }

        return Count;
    }
}
