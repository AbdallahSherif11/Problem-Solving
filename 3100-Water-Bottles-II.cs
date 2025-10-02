public class Solution 
{
    public int MaxBottlesDrunk(int numBottles, int numExchange) 
    {
        int ResultDrunk = numBottles;
        int FullBottles = 0;
        int EmptyBottles = numBottles;

        while (EmptyBottles >= 0)
        {
            if(FullBottles > 0 && EmptyBottles < numExchange) // We drink
            {
                EmptyBottles += FullBottles;
                ResultDrunk += FullBottles;
                FullBottles = 0;
                if (EmptyBottles - numExchange < 0) break;
            }
            else // We exchange
            {
                FullBottles ++;
                EmptyBottles -= numExchange;
                numExchange++;
            }
        }

        return ResultDrunk;
    }
}
