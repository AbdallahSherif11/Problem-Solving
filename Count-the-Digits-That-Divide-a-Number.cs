public class Solution 
{
    public int CountDigits(int num) 
    {
        int Count = 0;
        int Temp = num;

        while (Temp > 0)
        {
            int Digit = Temp % 10;
            if (num % Digit == 0)
            {
                Count++;
            }
            Temp /= 10;
        }

        return Count;
    }   
}