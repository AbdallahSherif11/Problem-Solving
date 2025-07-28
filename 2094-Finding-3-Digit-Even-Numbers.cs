public class Solution 
{
    public int[] FindEvenNumbers(int[] digits)
    {
        List<int> Result = new List<int>();

        int[] Temp = digits.Where(x => x % 2 == 0).ToArray();

        if (Temp.Length == 0 || digits.Length < 3)
        {
            return [];
        }

        // I am going to do a slow solution just to remember more syntax
        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] == 0) continue;

            for(int j = 0; j < digits.Length; j++)
            {
                if (j == i) continue;

                for (int k = 0; k < digits.Length ; k++)
                {
                    if (k == i || k == j || digits[k] % 2 != 0) continue;

                    string TempStr = $"{digits[i]}{digits[j]}{digits[k]}";
                    int TempInt = int.Parse(TempStr);
                    if (!Result.Contains(TempInt))
                    {
                        Result.Add(TempInt);
                    }
                }
            }
        }

        Result.Sort();
        return Result.ToArray();
    }
}
