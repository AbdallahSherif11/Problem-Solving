public class Solution 
{
    public bool IsSumEqual(string firstWord, string secondWord, string targetWord) 
    {
        string Result1 = "";
        string Result2 = "";
        string Target = "";
        char c = 'a';
        
        Dictionary<char,int> Alphabet = new Dictionary<char,int>();
        for (int i = 0; i < 26; i++)
        {
            Alphabet.Add(c, i);
            c++;
        }

        foreach (char X in firstWord)
        {
            Result1 += Alphabet[X];
        }
        foreach (char X in secondWord)
        {
            Result2 += Alphabet[X];
        }
        foreach (char X in targetWord)
        {
            Target += Alphabet[X];
        }
        int Temp1 = int.Parse(Result1);
        int Temp2 = int.Parse(Result2);
        int TempTarget = int.Parse(Target);

        return (Temp1 + Temp2 == TempTarget);
    }
}
