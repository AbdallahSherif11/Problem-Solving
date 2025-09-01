public class Solution 
{
    public string[] UncommonFromSentences(string s1, string s2) 
    {
        string[] Words1 = s1.Split(' ');
        string[] Words2 = s2.Split(' ');
        List<string> Result = new List<string>();

        foreach (string word in Words2)
        {
            var Temp = Words2.Count(X => X.Equals(word));
            if (!Words1.Contains(word) && !Result.Contains(word) && Temp == 1)
            {
                Result.Add(word);
            }
        }

        foreach (string word in Words1)
        {
            var Temp = Words1.Count(X => X.Equals(word));
            if (!Words2.Contains(word) && !Result.Contains(word) && Temp == 1)
            {
                Result.Add(word);
            }
        }

        return Result.ToArray();
    }
}
