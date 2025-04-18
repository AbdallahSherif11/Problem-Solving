public class Solution 
{
    public int BalancedStringSplit(string s) 
    {
        int balance = 0;
        int Result = 0;
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == 'L')
            {
                balance++;
            }
            else
            {
                balance--;
            }

            if(balance == 0)
            {
                Result++;
            }
        }


        return Result;
    }
}