public class Solution 
{
    public int MinMaxDifference(int num)
    {
        string numberString = num.ToString();
        string MaxNumberString = string.Empty;
        string MinNumberString = string.Empty;

        char Temp1 = default(char);  
        foreach(char c in numberString)
        {
            if(c != '9' && Temp1 == default(char))
            {
                Temp1 = c;
            }
            if(c != Temp1)
            {
                MaxNumberString += c;
            }
            else
            {
                MaxNumberString += '9';
            }
        }


        char Temp2 = default(char);
        foreach (char c in numberString)
        {
            if (c != '0' && Temp2 == default(char))
            {
                Temp2 = c;
            }
            if (c != Temp2)
            {
                MinNumberString += c;
            }
            else
            {
                MinNumberString += '0';
            }
        }

        int.TryParse(MaxNumberString, out int Max);
        int.TryParse(MinNumberString, out int Min);

        return Max - Min;
    }
}
