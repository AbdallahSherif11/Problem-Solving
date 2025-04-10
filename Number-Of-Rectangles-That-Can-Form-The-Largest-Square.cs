public class Solution 
{
    public int CountGoodRectangles(int[][] rectangles) 
    {
        List<int> MaxLen = new List<int>();
        for(int i = 0; i < rectangles.Length; i++)
        {
            MaxLen.Add(rectangles[i].Min());
        }

        return MaxLen.Count(n=> n == MaxLen.Max());
    }
}