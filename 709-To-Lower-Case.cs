public class Solution 
{
    public string ToLowerCase(string s) 
    {
        string Result = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] >= 'A' && s[i] <= 'Z')
            {
                int Temp = (s[i] + 32);
                Result += (char)Temp;
            }
            else
            {
                Result += s[i];
            }
        }
        return Result;
    }
}
