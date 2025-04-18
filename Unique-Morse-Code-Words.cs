public class Solution 
{
    public int UniqueMorseRepresentations(string[] words) 
    {
        Dictionary<char,string> MorseTranslate = new Dictionary<char, string>() 
        {
            {'a', ".-" },{'b', "-..." },{'c', "-.-." },{'d', "-.." },{'e', "." },{'f', "..-." },
            {'g', "--." },{'h', "...." },{'i', ".." },{'j', ".---" },{'k', "-.-" },{'l', ".-.." },
            {'m', "--" },{'n', "-." },{'o', "---" },{'p', ".--." },{'q', "--.-" },{'r', ".-." },
            {'s', "..." },{'t', "-" },{'u', "..-" },{'v', "...-" },{'w', ".--" },{'x', "-..-" },
            {'y', "-.--" },{'z', "--.." }
        };
        List<string> UniqueWords = new List<string>();
        for (int i = 0; i < words.Length; i++)
        {
            string Temp = "";
            for (int j = 0; j < words[i].Length; j++)
            {
                Temp += MorseTranslate[words[i][j]];
            }
            if (!UniqueWords.Contains(Temp))
            {
                UniqueWords.Add(Temp);
            }
        }
        return UniqueWords.Count;
    }
}