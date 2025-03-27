public class Solution 
{
    public string FreqAlphabets(string s) 
    {
        Dictionary<string, char> D1 = new Dictionary<string, char>();
        Dictionary<string, char> D2 = new Dictionary<string, char>();
        char myChar = 'a';
        string Result = "";


        for (int i = 1; i <= 26; i++)
        {
            if (i < 10)
            {
                D1[i.ToString()] = myChar;
            }
            else
            {
                D2[i.ToString() + "#"] = myChar;
            }
            myChar++;
        }

        for(int j = s.Length - 1; j >= 0; j--)
        {
            if (s[j] == '#')
            {
                string Temp = $"{s[j - 2]}{s[j - 1]}{s[j]}";
                Result = D2[Temp] + Result;
                j -= 2;
            }
            else
            {
                Result = D1[s[j].ToString()] + Result;
            }
        }

        return Result;
    }
}