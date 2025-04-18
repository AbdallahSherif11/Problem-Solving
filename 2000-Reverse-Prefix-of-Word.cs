public class Solution 
{
    public string ReversePrefix(string word, char ch) 
    {
        string TempWord1 = "";
        string TempWord2 = "";
        int TempHolder = 0;

        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == ch)
            {
                TempHolder = i;
                break;
            }
        }

        TempWord1 = word.Substring(0, TempHolder+1);
        TempWord2 = word.Substring(TempHolder+1, (word.Length- TempHolder - 1));

        char[] TempReverse = TempWord1.ToArray();
        Array.Reverse(TempReverse);
        TempWord1 = String.Concat(TempReverse);

        return TempWord1 + TempWord2;
    }
}
