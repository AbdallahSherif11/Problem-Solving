public class Solution 
{
    public int SumOfEncryptedInt(int[] nums) 
    {
        int Result = 0;

        foreach (int num in nums)
        {
            int Temp = num;
            int TempMax = 0;
            string Ones = "";
            while (Temp > 0)
            {
                int Digit = Temp % 10;
                if (Digit > TempMax)
                {
                    TempMax = Digit;
                }
                Temp = Temp / 10;
                Ones += '1';
            }
            Result += int.Parse(Ones) * TempMax;
        }

        return Result;
    }
}