public class Solution 
{
    public string FinalString(string s) 
    {
        string Result = "";

        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] != 'i')
            {
                Result += s[i];
            }
            else
            {
                char[] Temp = Result.ToArray();
                Array.Reverse(Temp);
                Result = string.Concat(Temp);
            }
        }

        return Result;
    }
}