public class Solution 
{
    public int VowelStrings(string[] words, int left, int right) 
    {
        int Result = 0;
        char[] Vowels = ['a', 'e', 'i', 'o', 'u'];

        for(int i = left; i <= right; i++)
        {
            if (Vowels.Contains(words[i][0]) && Vowels.Contains(words[i][words[i].Length-1]))
            {
                Result++;
            }
        }

        return Result;
    }
}