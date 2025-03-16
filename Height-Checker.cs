public class Solution 
{
    public int HeightChecker(int[] heights) 
    {
        int Count = 0;
        int ArrLen = heights.Length;
        int[] Expected = new int[ArrLen];
        Array.Copy(heights, Expected , ArrLen);
        Array.Sort(Expected);
        for (int i = 0; i < ArrLen; i++)
        {
            if (heights[i] != Expected[i])
            {
                Count++;
            }
        }

        return Count;
    }
}