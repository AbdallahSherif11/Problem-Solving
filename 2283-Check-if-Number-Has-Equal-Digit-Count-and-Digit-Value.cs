public class Solution 
{
    public bool DigitCount(string num) 
    {
        for(int i = 0; i < num.Length; i++)
        {
            char Temp = (char)('0' + i);
            int Test = num.Count(X => X == Temp);
            if (num.Count(X=> X == Temp) != char.GetNumericValue(num[i]))
            {
                return false;
            }
        }

        return true;
    }
}
