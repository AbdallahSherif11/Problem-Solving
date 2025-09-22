public class Solution 
{
    public char RepeatedCharacter(string s) 
    {
        List<char> Temp = new List<char>();
        char Result = '\0';
        foreach (char c in s)
        {
            if (!Temp.Contains(c))
            {
                Temp.Add(c);
            }
            else
            {
                Result = c;
                break;
            }
        }

        return Result;
    }
}