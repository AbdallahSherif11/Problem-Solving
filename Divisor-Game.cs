public class Solution 
{
    public bool DivisorGame(int n) 
    {
        int Count = 0;
        while(n > 1)
        {
            int x = 1;
            if(n - x <= 1 && Count % 2 == 0)
            {
                return true;
            }
            n = n - x;
            Count++;
        }

        return false;
    }
}