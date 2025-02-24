public class Solution 
{
    public string RemoveOuterParentheses(string s) 
    {
        string Result = "";
        int Temp = 0;
        int Counter = 0;

        for(int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                if(Counter == 0)
                {
                    Temp = i;
                }
                Counter++;
            }
            else
            {
                Counter--;
            }
            if(Counter == 0)
            {
                Result += s.Substring(Temp+1, (i - Temp - 1));
            }

        }

        return Result;
    }
}