public class Solution 
{
    public int CountBalls(int lowLimit, int highLimit) 
    {
        int Result = 0;
        Dictionary<int,int> BoxCount = new Dictionary<int,int>();

        for (int i = lowLimit; i <= highLimit; i++)
        {
            int Sum = 0;
            int X = i;
            while (X > 0)
            {
                int Temp = X % 10;
                Sum += Temp;
                X /= 10;
            }

            if (!BoxCount.ContainsKey(Sum))
            {
                BoxCount[Sum] = 1;
            }
            else
            {
                BoxCount[Sum]++;
            }
        }
        Result = BoxCount.Values.Max();

        return Result;
    }
}
