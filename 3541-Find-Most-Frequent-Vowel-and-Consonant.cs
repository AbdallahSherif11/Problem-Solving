public class Solution 
{
    public int MaxFreqSum(string s) 
    {
        int Result = 0;
        char[] Vowels = { 'a', 'e', 'i', 'o', 'u' };
        char[] Consonat = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
        Dictionary<char,int> VowelFrequency = new Dictionary<char,int>();
        Dictionary<char,int> ConsonantFrequency = new Dictionary<char,int>();

        foreach (char c in Vowels)
        {
            VowelFrequency.Add(c, 0);   
        }
        foreach (char c in Consonat)
        {
            ConsonantFrequency.Add(c, 0);
        }
        foreach (char c in s)
        {
            if (VowelFrequency.ContainsKey(c))
            {
                VowelFrequency[c]++;
            }
            else
            {
                ConsonantFrequency[c]++;
            }
        }
        Result = ConsonantFrequency.Values.Max() + VowelFrequency.Values.Max();

        return Result;
    }
}
