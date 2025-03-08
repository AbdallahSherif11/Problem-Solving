public class Solution 
{
    public string MergeAlternately(string word1, string word2) 
    {
        int MyLength = word1.Length + word2.Length;
        List<char> l1 = new List<char>();
        int x = 0;
        int y = 0;
        for (int i = 0; i < MyLength; i++)
        {
            if(x < word1.Length)
            {
                l1.Add(word1[x]);
            }
            if(y < word2.Length)
            {
                l1.Add(word2[y]);
            }
            x++;
            y++;
        }

        return string.Concat(l1);
    }
}
