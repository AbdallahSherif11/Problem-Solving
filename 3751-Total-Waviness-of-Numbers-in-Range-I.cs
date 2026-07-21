public class Solution 
{
    public int TotalWaviness(int num1, int num2) 
    {
        int Result = 0;
        string Temp = "";

        for(int i = num1; i <= num2; i++)
        {
            Temp = i.ToString();
            for(int j = 1; j < Temp.Length - 1; j++)
            {
                if ((Temp[j] > Temp[j+1] && Temp[j] > Temp[j - 1]) || (Temp[j] < Temp[j + 1] && Temp[j] < Temp[j - 1]))
                {
                    Result++;
                }
            }
        }

        return Result;
    }
}