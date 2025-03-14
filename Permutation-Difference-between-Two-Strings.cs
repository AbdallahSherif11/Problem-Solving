public class Solution 
{
    public int FindPermutationDifference(string s, string t) 
    {
        int PermutationDifference = 0;

        for(int i = 0; i< s.Length; i++)
        {
            for(int j = 0; j < t.Length; j++)
            {
                if (s[i] == t[j])
                {
                    PermutationDifference += int.Abs(i - j);
                }
            }
        }

        return PermutationDifference;
    }
}