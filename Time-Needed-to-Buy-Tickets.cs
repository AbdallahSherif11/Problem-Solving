public class Solution 
{
    public int TimeRequiredToBuy(int[] tickets, int k) 
    {
        int Seconds = 0;
        while (tickets[k] > 0)
        {
            for(int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] > 0 && tickets[k] > 0)
                {
                    tickets[i]--;
                    Seconds++;
                }
            }
        }

        return Seconds;
    }
}