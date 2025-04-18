public class Solution 
{
    public IList<string> CellsInRange(string s) 
    {
        IList<string> list = new List<string>();
        char ColumnStart = s[0];
        char ColumnEnd = s[3];
        for (char j = ColumnStart; j <= ColumnEnd; j++)
        {
            char RowStart = s[1];
            char RowEnd = s[4];
            for (char i = RowStart; i <= RowEnd; i++)
            {
                list.Add($"{j}{i}");
            }
        }

        return list;
    }
}
