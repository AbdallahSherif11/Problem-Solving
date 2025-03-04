public class Solution 
{
    public string ConvertDateToBinary(string date) 
    {
        string DateBinary = "";
        string YearBinary = "";
        string MonthBinary = "";
        string DayBinary = "";

        for (int i = 0; i < 4; i++)
        {
            YearBinary += date[i];
        }
        YearBinary = $"{int.Parse(YearBinary):b}";

        for (int i = 5; i < 7; i++)
        {
            MonthBinary += date[i];
        }
        MonthBinary = $"{int.Parse(MonthBinary):b}";

        for (int i = 8; i < 10; i++)
        {
            DayBinary += date[i];
        }
        DayBinary = $"{int.Parse(DayBinary):b}";

        DateBinary = YearBinary + "-" + MonthBinary + "-" + DayBinary;

        Console.WriteLine(DateBinary);

        return DateBinary;
    }
}