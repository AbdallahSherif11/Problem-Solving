public class Solution 
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) 
    {
        IList<bool> result = new List<bool>();
        int GreatestAmountOfCandies = candies[0];
        for(int i = 1; i < candies.Length; i++)
        {
            if (candies[i] > GreatestAmountOfCandies)
            {
                GreatestAmountOfCandies = candies[i];
            }
        }
        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[i] + extraCandies >= GreatestAmountOfCandies)
            {
                result.Add(true);
            }
            else
            {
                result.Add(false);
            }
        }
        return result;
    }
}