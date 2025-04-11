public class Solution 
{
    public bool HalvesAreAlike(string s) 
    {
        int Temp = s.Length / 2;
        string a = s.Substring(0, Temp).ToLower();
        string b = s.Substring(Temp, Temp).ToLower();

        int CountA = 0;
        int CountB = 0;

        string vowels = "aeiou";
        for (int i = 0; i < a.Length; i++)
        {
            if (vowels.Contains(a[i]))
            {
                CountA++;
            }
            if(vowels.Contains(b[i])) 
            { 
                CountB++; 
            }
        }

        return CountA == CountB;
    }
}
