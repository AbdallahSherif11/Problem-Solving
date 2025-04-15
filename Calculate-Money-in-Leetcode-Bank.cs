public class Solution 
{
    public int TotalMoney(int n) 
    {
        int Count = 0;
        int saved = 0;
        int i = 0;
        for(i = i+1; Count < n; i++)
        {
            for(int j = i; j < 7+i && Count < n; j++)
            {
                saved += j;
                Count++;
            }
        }
        return saved;
    }
}