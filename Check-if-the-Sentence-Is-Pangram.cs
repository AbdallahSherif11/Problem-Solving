public class Solution 
{
    public bool CheckIfPangram(string sentence) 
    {
        string Alphabet = "abcdefghijklmnopqrstuvwxyz";
        for(int i = 0; i < Alphabet.Length; i++)
        {
            if (!sentence.Contains(Alphabet[i]))
            {
                return false;
            }
        }

        return true;
    }
}