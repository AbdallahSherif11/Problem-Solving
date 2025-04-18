public class Solution 
{
    public int MaxDepth(string s) 
    {
        int CurrentCount = 0;
        int MaxNest = 0;
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '(')
            {
                CurrentCount++;
            }
            else if (s[i] == ')')
            {
                if(CurrentCount > MaxNest)
                {
                    MaxNest = CurrentCount;
                }
                CurrentCount--;
            }
        }

        return MaxNest;
    }   
}
