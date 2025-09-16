public class Solution 
{
    public int GetLucky(string s, int k) 
    {
        int Result = 0;
        string Temp = "";
        Dictionary<char,int> Alphabet = new Dictionary<char,int>();
        char c = 'a';

        for (int i = 1; i <= 26; i++)
        {
            Alphabet.Add(c, i);
            c++;
        }

        foreach (char X in s)
        {
            Temp += Alphabet[X];
        }

        for (int j = 0; j < k; j++)
        {
            foreach (char X in Temp)
            {
                Result += int.Parse(X.ToString());
            }
            Temp = Result.ToString();
            if((j+1) < k)
            {
                Result = 0;
            }
        }


        return Result;
    }
}
