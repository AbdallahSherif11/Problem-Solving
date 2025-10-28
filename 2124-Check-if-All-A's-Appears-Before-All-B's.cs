public class Solution 
{
    public bool CheckString(string s) 
    {
        int FirstB = s.IndexOf('b');
        if (FirstB == -1)
        {
            return true;
        }
        for(int i = FirstB; i < s.Length; i++)
        {
            if(s[i] == 'a')
            {
                return false;
            }
        }

        return true;
    }
}
