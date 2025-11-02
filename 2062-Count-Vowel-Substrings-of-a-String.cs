public class Solution 
{
    public int CountVowelSubstrings(string word) 
    {
        int Max = 0;
        if (word.Length >= 5 && word.Contains('a') && word.Contains('e') && word.Contains('i') && word.Contains('o') && word.Contains('u'))
        {
            for(int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                {
                    string Temp = $"{word[i]}";
                    for(int j = i + 1; j < word.Length; j++)
                    {
                        if (word[j] == 'a' || word[j] == 'e' || word[j] == 'i' || word[j] == 'o' || word[j] == 'u')
                        {
                            Temp += word[j];
                            if(Temp.Length >= 5 &&  Temp.Contains('a') && Temp.Contains('e') && Temp.Contains('i') && Temp.Contains('o') && Temp.Contains('u'))
                            {
                                Max++;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            return Max;
        }
        else
        {
            return 0;
        }
    }
}
