public class Solution 
{
    public int CountCharacters(string[] words, string chars) 
    {
        int Result = 0;

        foreach (string word in words)
        {
            int Temp = 0;
            foreach(char c in word)
            {
                if(word.Count(X=> X == c) <= chars.Count(X => X == c))
                {
                    Temp++;
                }
            }
            if(Temp == word.Length)
            {
                Result += Temp;
            }
        }

        return Result;
    }
}
