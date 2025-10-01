public class Solution 
{
    public int NumWaterBottles(int numBottles, int numExchange) 
    {
        int Drinkable = numBottles;
        int Result = numBottles;
        while (Drinkable > 0 && Drinkable >= numExchange)
        {
            Result += Drinkable / numExchange;

            Drinkable = (Drinkable / numExchange) + (Drinkable % numExchange);
        }

        return Result;
    }
}
