public class Solution 
{
    public string SortSentence(string s) 
    {
        string[] words = s.Split(' ');
        string[] ArrSort = new string[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            int x = int.Parse(words[i].Substring(words[i].Length - 1)) - 1;
            ArrSort[x] = words[i].Substring(0, words[i].Length - 1);
        }
        return string.Join(" ", ArrSort);
    }
}