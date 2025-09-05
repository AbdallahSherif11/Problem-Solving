public class Solution 
{
    public int CountOperations(int num1, int num2) 
    {
        int Result = 0;
        while (num1 != 0 && num2 != 0)
        {
            if (num1 < num2)
            {
                num2 -= num1;
                Result++;
            }
            else if (num2 < num1)
            {
                num1 -= num2;
                Result++;
            }
            else
            {
                num1 -= num2;
                num2 -= num1;
                Result++;
            }
        }
        return Result;
    }
}
